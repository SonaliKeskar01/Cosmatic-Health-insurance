using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ADO.NET
{
    class StudentDBV2
    {
        public StudentCourses GetStudents()
        {
            List<Student> students = new List<Student>();
            List<Course> courses = new List<Course>();
            StudentCourses result = new StudentCourses();
            SqlConnection con = null;
            SqlTransaction tran = null;
            try
            {         
                con = new SqlConnection(ConfigConstant.ConnectionString);

             tran=  con.BeginTransaction();//Transaction begin

                //to prepare command--we can use SqlDataAdapter no need to write sql command class
                // SqlCommand cmd = new SqlCommand("select * from Student;select * from Course", con);
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Student;select * from Course", con);

                //To open Connection-is mandatory
                // con.Open();//no need to connection open

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                //To excute Query
                //SqlDataReader reader = cmd.ExecuteReader();//no need


                //To check if there are rows or not 
               if(ds !=null && ds.Tables != null && ds.Tables.Count>0)
                 {
                    //read first table
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Student s = new Student();
                        s.id = (int)row["id"];
                        s.Name = row["Name"].ToString();
                        s.CorseId = (int)row["CorseId"];
                        students.Add(s);
                    }

                    //read second table
                    if(ds.Tables.Count>1)
                    {
                        foreach (DataRow row in ds.Tables[1].Rows)
                        {
                            Course c = new Course();
                            c.CourseId = (int)row["CourseId"];
                            c.CourseName = row["CourseName"].ToString();
                            courses.Add(c);
                        }

                    }
                }
                result.Courses = courses;
                result.Students = students;

                tran.Commit();//commited
                return result;
            }
            catch (Exception e)
            {
                if (tran != null)
                    tran.Rollback();
                return result;


            }
            

        }
    }
}
