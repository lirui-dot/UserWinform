using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserWinform.Models;

namespace UserWinform
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        static UserContext db = new UserContext();
        
   
            

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register i = new Register();
            this.Hide();
            i.Show();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {

            var p = await db.Provinces.FindAsync(1);
            if (p == null)
            {
                string url = "https://api.jisuapi.com/area/province?appkey=1b5f267715e671b2";
                var handler = new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip
                };
                using (var http = new HttpClient(handler))
                {
                    var response = await http.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                    string json = await response.Content.ReadAsStringAsync();
                    ProvinceDetails province = JsonConvert.DeserializeObject<ProvinceDetails>(json);
                    
                    for (int i = 0; i < province.result.Count; i++)
                    {
                        Province prs = new Province();
                        prs.id = province.result[i].id;
                        prs.name = province.result[i].name;
                        prs.parentid = province.result[i].parentid;
                        prs.parentname = province.result[i].parentname;
                        prs.areacode = province.result[i].areacode;
                        prs.zipcode = province.result[i].zipcode;
                        prs.depth = province.result[i].depth;

                        if (prs != null)
                        {
                            db.Provinces.Add(prs);
                            await db.SaveChangesAsync();
                        }
                    }
                   
                }
            }

            var c = await db.Provinces.FindAsync(499);
            if (c == null)
            {
                for (int w = 1; w < 10; w++)
                {
                    string url = "https://api.jisuapi.com/area/city?parentid=" + w + "&appkey=1b5f267715e671b2";

                    var handler = new HttpClientHandler()
                    {
                        AutomaticDecompression = DecompressionMethods.GZip
                    };
                    using (var http = new HttpClient(handler))
                    {
                        var response = await http.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                        string json = await response.Content.ReadAsStringAsync();
                        ProvinceDetails province = JsonConvert.DeserializeObject<ProvinceDetails>(json);
                       
                        for (int i = 0; i < province.result.Count; i++)
                        {
                            Province prs = new Province();
                            prs.id = province.result[i].id;
                            prs.name = province.result[i].name;
                            prs.parentid = province.result[i].parentid;
                            prs.parentname = province.result[i].parentname;
                            prs.areacode = province.result[i].areacode;
                            prs.zipcode = province.result[i].zipcode;
                            prs.depth = province.result[i].depth;

                            if (prs != null)
                            {
                                db.Provinces.Add(prs);
                                await db.SaveChangesAsync();
                            }
                        }

                    }
                }
            }








            string username = txtUserName.Text.Trim();
                string pwd = txtPassWord.Text.Trim();
                if (username == "")
                {
                    MessageBox.Show("用户名不能为空");
                    return;
                }
                if (pwd == "")
                {
                    MessageBox.Show("密码不能为空");
                    return;
                }
                var user = db.Users.Where(m => m.UserName == username).ToList();
                if (user.Count >= 1)
                {
                User user1 = db.Users.SingleOrDefault(m=>m.UserName==username&&m.PassWord==pwd);
               
                if (user1!=null)
                    {
                        MessageBox.Show("登录成功！！！");
                        Personal ps = new Personal(user1.Id);
                        this.Hide();
                        ps.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码不正确！");
                    }
                }
                else
                {
                    MessageBox.Show("用户名不存在");
                }
            }
        
    }
}
