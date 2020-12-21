using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserWinform.Models;

namespace UserWinform
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        static UserContext db = new UserContext();
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string pwd = txtPassWord.Text.Trim();
            string cpwd = txtCpassWord.Text.Trim();
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
            if (cpwd=="") 
            {
                MessageBox.Show("请再次输入密码不能为空！");
                return;
            }
            if (pwd!=cpwd) 
            {
                MessageBox.Show("二次密码不一致请重新输入！！");
            }
            var register = db.Users.Where(m => m.UserName == username).ToList();
            if (register.Count == 0)
            {
                User user = new User();
                user.UserName = username;
                user.PassWord = pwd;
                if (user!=null) 
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("注册成功");
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
            }
            else 
            {
                MessageBox.Show("用户名重复，请重新输入");
            }
        }
    }
}
