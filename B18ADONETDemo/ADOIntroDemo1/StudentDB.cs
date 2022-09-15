using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace ADOIntroDemo1
{
    class StudentDB
    {

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            //Step-1//connectionstring we can use for -server and database details
            string connectionString = "data source=.\\sqlexpress; database=PracticeDB;integrated security=true;";

            //step-2//sqlconnection class--to establish connection with database -open/colse connection with database

            //**1st way**

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = connectionString;

            //**2nd way**
            SqlConnection con = new SqlConnection(connectionString);

            //Step 3: SqlCommand class--prepare command

            SqlCommand cmd = new SqlCommand("select * from student", con);

            //****Or

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "Select * from student";
            //cmd.Connection = con;

            //step 4:To open connection
            con.Open();

            //step 5:to execute query
            SqlDataReader reader = cmd.ExecuteReader();//here ExecuteReader() method helps to return sqldata

            //step 6:to check if there are rows or not  using HasRows 

            if (reader.HasRows)//HasRows helps to find there are row present or not
            {


                //To iterate and read all records from result-using loop
                //we want to read rows here-if we want to return all row then we can use loop-
                while (reader.Read())
                {
                    //int id=(int) reader["Id"];
                    // string name = reader["Name"].ToString();
                    // int courseId = (int)reader["CorseId"];
                    // Console.WriteLine($"{id} | {name} | {courseId}");

                    //more redable
                    Student s = new Student();

                    s.id = (int)reader["Id"];
                    s.Name = reader["Name"].ToString();
                    s.CorseId = (int)reader["CorseId"];
                    students.Add(s);//adding student in list
                }

            }


            con.Close();
            return students;
        }

        public Student GetStudentById(int id)
        {

            Student s = new Student();
            string cs = "data source=.\\sqlexpress;database=PracticeDB;integrated security=true;";

            SqlConnection con = new SqlConnection(ConfigConstant.ConnectionString);

            string cmdText = $"Select * from Student where Id={id}";
            SqlCommand cmd = new SqlCommand(cmdText, con);

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

    }     
}
