using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkBackToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void linkLoginUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            AccountDB db = new AccountDB();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string role;
            

            if(db.Login(username,password,out role))
            {
                //MessageBox.Show("Login Success...");
                //open student manage page

                //check role
                //admin=> manage student role
                //student=>student profile

               if(role.Equals("Admin"))
                {
                    Form1 form = new Form1();
                    form.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Insufficient permission to manage students..");
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Username or Password Incorrect....");
            }
        }
    }
}
