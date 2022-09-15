using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class StudentDB
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            //server and database details=using connection string
           // string connectionstring = "data source=.\\sqlexpress;database=PracticeDB;integrated security=true;";

            //**To connect to open to establish connection with database

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = ConfigConstant.ConnectionString;

            SqlConnection con = new SqlConnection(ConfigConstant.ConnectionString);


            //to prepare command
            SqlCommand cmd = new SqlCommand("select * from Student", con);//1st way
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "Select * from student";
            //cmd.Connection = con;

            //To open Connection
            con.Open();

            //To excute Query
            SqlDataReader reader = cmd.ExecuteReader();

            //To check if there are rows or not 
            if (reader.HasRows)
            {
             
                //To iterate and read all records from result
                while (reader.Read())
                {
                    Student s = new Student();

                    s.id = (int)reader["Id"];
                    s.Name = reader["Name"].ToString();
                    s.CorseId = (int)reader["CorseId"];
                    students.Add(s);//Adding student to list
                }

            }
           
            con.Close();
            return students;

        }

        public Student GetStudentById(int id)
        {
            Student s = new Student();

            //string cs = "data source=.\\sqlexpress;database=PracticeDB;integrated security=true;";

            SqlConnection con = new SqlConnection(ConfigConstant.ConnectionString);

            string cmdText = $"Select * from Student where Id={id}";
            SqlCommand cmd = new SqlCommand(cmdText,con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    s.id = (int)reader["Id"];
                    s.Name = reader["Name"].ToString();
                    s.CorseId = (int)reader["CorseId"];
                }
            }
            con.Close();

            return s;
        }

        public bool Create (Student student)
        {
            SqlConnection con = new SqlConnection(ConfigConstant.ConnectionString);
            
            
            string cmdText = $"insert into Student (id,Name,CorseId)values({student.id} , '{student.Name}' ,{student.CorseId})";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();//if only use insert/update/delete with no return result
                return true;
            }
            catch(Exception e)

            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
