using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserWinform.Models;

namespace UserWinform
{
    public partial class Personal : Form
    {
        int id;
        public Personal(int id)
        {
            InitializeComponent();

            this.id = id;
        }
        static UserContext db = new UserContext();
        string str;
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            
            string age= txtAge.Text.Trim();
            string url = txtUrl.Text.Trim();
            string gender = string.Empty;
            if (age=="") 
            {
                MessageBox.Show("年龄不能为空");
                return;
            }
            if (rdoNan.Checked)
            {
                gender = "男";
            }
            else 
            {
                gender = "女";
            }
            if (url=="") 
            {
                MessageBox.Show("Url不能为空！");
            }
            string u= @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&$%\$#\=~])*$";
            Regex x = new Regex(u);
            Match m = x.Match(url);

            if (!m.Success) 
            {
                MessageBox.Show("您的Url格式不正确请重新输入！");
                return;
            };
            string pro = comProvince.Text.Trim();
            Province a = db.Provinces.SingleOrDefault(p => p.name == pro);
            string city = comCity.Text.Trim();
            Province b = db.Provinces.SingleOrDefault(p => p.name == city);
            var user = db.Users.Find(id);
            user.Age = int.Parse(age);
            user.Gender = gender;
            user.ProvinceId = a.id;
            user.CityId = b.id;

          
           
            FileStream fs = new FileStream(str, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes(Convert.ToInt32(fs.Length));//转成二进制数据的操作

            var path = this.GetType().Assembly.Location;
            string paths = path.Replace("bin\\Debug\\UserWinform.exe","");
            string fileUrl = Guid.NewGuid().ToString() + ".png";
            string url1 = paths + @"\wwwroot\Image\" + fileUrl;

            System.IO.File.WriteAllBytes(url1, imgBytesIn);
            string urlPath = url1.Replace(paths, "");  //转换成相对路径

            user.Image = urlPath;
            user.Url = url;
            if (user!=null) 
            {
                db.SaveChanges();
                MessageBox.Show("完成");
            }


        }

        private void Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    e.Handled = true;
                    MessageBox.Show("您输入的年龄格式不正确，请重新输入");
                }
            }
        }

        
        public void City() 
        {
            
            comCity.Items.Clear();
            //根据选取的省份获取省份编号
            string proName = comProvince.SelectedItem.ToString();
            Province city = db.Provinces.SingleOrDefault(m => m.name == proName);
            
            var dbCity = db.Provinces.Where(m => m.parentid == city.id).ToList();
            //根据选取的省份编号绑定城市数据

            if (dbCity != null)
            {
                foreach (Province data in dbCity)
                {
                    comCity.Items.Add(data.name);
                }
                comCity.SelectedItem = comCity.Items[0];
            }
        }

         
        private void Personal_Load(object sender, EventArgs e)
        {
            
            var user = db.Users.Find(id);
            int age = user.Age;
            string age1 = Convert.ToString(age);
            txtAge.Text = age1;
           
            if (user.Gender=="男")
            {
                rdoNan.Checked = true;
            }
            else
            {
                rdoNv.Checked = true;
            }

            var pro = db.Provinces.Where(m => m.id < 35).ToList();
            if (pro != null)
            {
                
                foreach (Province data in pro)
                {
                    comProvince.Items.Add(data.name);
                    if (data.id==user.ProvinceId) 
                    {
                        comProvince.SelectedIndex = comProvince.Items.IndexOf(data.name);
                    }
                }
               
            }
   
            var dbCity = db.Provinces.Where(m => m.parentid == user.ProvinceId).ToList();
            //根据选取的省份编号绑定城市数据

            if (dbCity != null)
            {
                comCity.Items.Clear();
                foreach (Province data in dbCity)
                {
                    comCity.Items.Add(data.name);
                    if (data.id==user.CityId) 
                    {
                        comCity.SelectedIndex = comCity.Items.IndexOf(data.name);
                    }
                }
                
            }
            var path = this.GetType().Assembly.Location;
            string paths = path.Replace("bin\\Debug\\UserWinform.exe", "");
            
            string url1 = paths + user.Image;
            if (user.Image != null)
            {
                FileStream fs = new FileStream(url1, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
                MemoryStream ms = new MemoryStream(buffer);
                Bitmap bit = new Bitmap(ms);
                pictureBox1.Image = bit;
            }
            txtUrl.Text = user.Url;


        }

        private void comProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            City();
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog i = new OpenFileDialog();
            if (i.ShowDialog() == DialogResult.OK)
            {
                str = i.FileName;
                pictureBox1.Image = Image.FromFile(str);
            }


        }
    }
}
