using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class StudentDBV1
    {
        public StudentCourses GetStudents()
        {
            List<Student> students = new List<Student>();
            List<Course> courses = new List<Course>();
            StudentCourses result = new StudentCourses();
            SqlConnection con = null;
            try
            {
                
                //server and database details=using connection string
                // string connectionstring = "data source=.\\sqlexpress;database=PracticeDB;integrated security=true;";

                //**To connect to open to establish connection with database

                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = ConfigConstant.ConnectionString;

                 con = new SqlConnection(ConfigConstant.ConnectionString);


                //to prepare command
                SqlCommand cmd = new SqlCommand("select * from Student;select * from Course", con) ;  
                //1st way
                 //SqlCommand cmd = new SqlCommand();
                 //cmd.CommandText = "Select * from student";
                                                                              //cmd.Connection = con;

                //To open Connection-is mandatory
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

               if( reader.NextResult())
                {
                   if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            Course c = new Course();
                            c.CourseId = (int)reader["CourseId"];
                            c.CourseName = reader["CourseName"].ToString();
                            courses.Add(c);
                        }
                    }

                }
                result.Courses = courses;
                result.Students = students;
                
                return result;
            }
            catch(Exception e)
            {
                return result;


            }
            finally
            {if (con != null)
                con.Close();
            }

        }

        public Student GetStudentById(string id)
        {
            Student s = new Student();

            //string cs = "data source=.\\sqlexpress;database=PracticeDB;integrated security=true;";

            SqlConnection con = new SqlConnection(ConfigConstant.ConnectionString);

            //In sql database

                //            alter proc Usp_StudentById
                //@id varchar(30)
                //as
                //begin
                //select* from Student where id = @id
                //end

            // string cmdText = $"Select * from Student where Id=@id";
            string cmdText = "Usp_StudentById";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    s.id = (int)reader["Id"];
                    s.Name = reader["Name"].ToString();
                    s.CorseId = (int)reader["CorseId"];
                }
            }
            con.Close();

            return s;
        }

        public bool Create(Student student)
        {
            SqlConnection con = new SqlConnection(ConfigConstant.ConnectionString);
            //int rows = 0;
            bool result = false;
            //string cmdText = $"insert into Student (id,Name,CorseId)values({student.id} , '{student.Name}' ,{student.CorseId})";
            
            try
            {
                string cmdText = "usp_Createstudent";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", student.id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@CorseId", student.CorseId);

                SqlParameter insertStatus = new SqlParameter();
                insertStatus.ParameterName = "@InsertStatus";
                insertStatus.SqlDbType = SqlDbType.Bit;
                insertStatus.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(insertStatus);
                con.Open();
                  cmd.ExecuteNonQuery();//if only use insert/update/delete with no return result
                result = (bool)insertStatus.Value;
                return result;
            }
            catch (Exception e)

            {
                // return rows;
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public int StudentCount()
        {
            int result = -1;
            SqlConnection con = null;

            try{
                con = new SqlConnection(ConfigConstant.ConnectionString);
                string cmdText = "select dbo.fn_StudentCount()";
                SqlCommand cmd = new SqlCommand(cmdText ,con);
                con.Open();
             result =(int) cmd.ExecuteScalar();

                return result;
            }
            catch(Exception ex)
            {
                return result;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}
