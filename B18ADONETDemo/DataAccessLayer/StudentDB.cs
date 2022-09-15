using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DataAccessLayer
{
   public class StudentDB
    {
        public List<Student> Students()
        {
            List<Student> students = new List<Student>();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConfigConstant.ConnectionString);

                SqlCommand cmd = new SqlCommand(DbConstants.spStudents, con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();


                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {

                    //To iterate and read all records from result
                    while (reader.Read())
                    {
                        Student s = new Student();

                        s.id = (int)reader["Id"];
                        s.Name = reader["Name"].ToString();
                        s.CorseId = (int)reader["CorseId"];
                        s.IsActive = (bool)reader["IsActive"];
                        students.Add(s);//Adding student to list
                    }

                }

                con.Close();
                return students;
            }
            catch(Exception ex)
            {
                return students;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public Student StudentById(int id)
        {
            Student s = new Student();
            SqlConnection con = null;
            try
            {

               con = new SqlConnection(ConfigConstant.ConnectionString);

              
                SqlCommand cmd = new SqlCommand(DbConstants.spStudentDetailsByRollnumber, con);
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
            catch(Exception ex)
            {
               
                    return s;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public bool Create(Student student)
        {
            SqlConnection con = null;
            bool insertStatus = false;
            try
            {
                 con= new SqlConnection(ConfigConstant.ConnectionString);


                SqlCommand cmd = new SqlCommand(DbConstants.spCreateNewStudent, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", student.id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@CorseId", student.CorseId);

                //To access out parameter 
                SqlParameter status = new SqlParameter();
                status.ParameterName = "@InsertStatus";
                status.Direction = ParameterDirection.Output;
                status.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(status);
                con.Open();
                cmd.ExecuteNonQuery();//if only use insert/update/delete with no return result

                insertStatus = (bool)status.Value;
                return insertStatus;
            }
            catch (Exception e)

            {
                return insertStatus;
            }
            finally
            { //if(con != null)
                con.Close();
            }
        }

        public bool Update(int id,Student student)
        {
            SqlConnection con = null;
            bool updateStatus = false;
            try
            {
                con = new SqlConnection(ConfigConstant.ConnectionString);


                SqlCommand cmd = new SqlCommand(DbConstants.spUpdateStudent, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", student.id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@CorseId", student.CorseId);

                //To access out parameter 
                SqlParameter status = new SqlParameter();
                status.ParameterName = "@UpdateStatus";
                status.Direction = ParameterDirection.Output;
                status.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(status);
                con.Open();
                cmd.ExecuteNonQuery();//if only use insert/update/delete with no return result

                updateStatus = (bool)status.Value;
                return updateStatus;
            }
            catch (Exception e)

            {
                return updateStatus;
            }
            finally
            { //if(con != null)
                con.Close();
            }
        }

        public bool Delete(int id)
        {
            SqlConnection con = null;
            bool deleteStatus = false;
            try
            {
                con = new SqlConnection(ConfigConstant.ConnectionString);


                SqlCommand cmd = new SqlCommand(DbConstants.spDeleteStudent, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                //To access out parameter 
                SqlParameter status = new SqlParameter();
                status.ParameterName = "@DeletedStatus";
                status.Direction = ParameterDirection.Output;
                status.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(status);
                con.Open();
                cmd.ExecuteNonQuery();//if only use insert/update/delete with no return result

                deleteStatus = (bool)status.Value;
                return deleteStatus;
            }
            catch (Exception e)

            {
                return deleteStatus;
            }
            finally
            { //if(con != null)
                con.Close();
            }
        }

        public bool ArchieveToStudents()
        {
            SqlConnection con = new SqlConnection(ConfigConstant.ConnectionString);
            SqlConnection archiveCon = new SqlConnection(ConfigConstant.ArchievedDBConnectionString);
            SqlTransaction sqlTransaction = null;

            var result = false;
            try
            {
                con.Open();
                sqlTransaction = con.BeginTransaction();

                SqlCommand cmd = new SqlCommand(DbConstants.spArchiveStudent,con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = sqlTransaction;
                SqlDataReader reader=cmd.ExecuteReader();

                //SQlBullkCopy--copy student 
                SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(archiveCon);
                sqlBulkCopy.DestinationTableName = "Student";
                archiveCon.Open();
                sqlBulkCopy.WriteToServer(reader);

                //delete from orignal student table

                //while(reader.Read())
                //{
                //  int id= (int) reader["id"];
                //    Delete(id);
                //}
                sqlTransaction.Commit();
                return result;
            }
            catch
            {
                sqlTransaction.Rollback();
                return result;
            }
            finally
            {
                if (con != null) con.Close();
                if (archiveCon != null) archiveCon.Close();
            }
        }
    }
}
