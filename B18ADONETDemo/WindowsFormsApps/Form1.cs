using DataAccessLayer;
using Models;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gridAll_Click(object sender, EventArgs e)
        {
            LoadAllStudents();
            btnExportExcel.Enabled = true;
        }

        void LoadAllStudents()
        {
            //return student from db
            StudentDB db = new StudentDB();
            var students = db.Students();
            //show student from gridStudent
            gridStudents.DataSource = students;
        }
        private void btnCREATE_Click(object sender, EventArgs e)
        {

            Student s = new Student()
            {
                id = int.Parse(txtid.Text),
                Name = txtName.Text,
                CorseId = int.Parse(txtCorseid.Text)

            };

            StudentDB db = new StudentDB();
            if(db.Create(s))
            {
                MessageBox.Show("Student created Successfully..");
                LoadAllStudents();
            }
            else
            {
                MessageBox.Show("Student creation Failed..");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);

            StudentDB db = new StudentDB();

            Student s = db.StudentById(id);

            if(s!=null)
            {
                txtName.Text = s.Name;
                txtCorseid.Text = s.CorseId.ToString();
                MessageBox.Show("Student Loaded");
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Student Load Failed");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                id = int.Parse(txtid.Text),
                Name = txtName.Text,
                CorseId = int.Parse(txtCorseid.Text)

            };

            StudentDB db = new StudentDB();
            if (db.Update(s.id, s))
            {
                MessageBox.Show("Student Updated Successfully..");
                LoadAllStudents();
            }
            else
            {
                MessageBox.Show("Student Updation Failed..");
            }

        
    }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);

            StudentDB db = new StudentDB();
            db.Delete(id);

            Student s = db.StudentById(id);

            if (s != null)
            {
               
                MessageBox.Show("Student Deleted Successfully..");
                
            }
            else
            {
                MessageBox.Show("Student Delete Failed");
            }


        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Home homePage = new Home();
            homePage.Show();
            this.Hide();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export To Excel Clicked");
        }
    }
}
