using DataAccessLayer;
using Models.Account;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Initialize();

        }

        private void Initialize()
        {
            AccountDB db = new AccountDB();
            List<UserType> userTypes = db.UserTypes();
            cbUserType.Items.AddRange(userTypes.ToArray<UserType>());
        }
        private void linkBackToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountDB db = new AccountDB();
            Users user = new Users()
            {
                UserName = txtUsername.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text

            };


            string userTypeName = cbUserType.Text;
            if(db.Register(user, userTypeName))
            {
                MessageBox.Show("Registration Successful");
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }


        }
    }
}
