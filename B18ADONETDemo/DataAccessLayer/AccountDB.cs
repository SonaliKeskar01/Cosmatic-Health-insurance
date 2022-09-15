using Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data;

namespace DataAccessLayer
{
  public  class AccountDB
    {

        public List<UserType>UserTypes()
        {
            List<UserType> userTypes = new List<UserType>();
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(ConfigConstant.StudentDBConnectionString);
                SqlCommand cmd = new SqlCommand(DbConstants.spGetUserTypes, con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
               SqlDataReader reader= cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        UserType type = new UserType()

                        {
                            UserTypeId = (int)reader["UserTypeId"],
                            UserTypeGuid = (Guid)reader["UserTypeGuid"],
                            UserTypeName = reader["UserTypeName"].ToString()

                        };

                        userTypes.Add(type);
                    }
                }
            }
           
            finally
            {
                if (con != null)
                    con.Close();
            }
            return userTypes;
        }

        public bool Register(Users users,string userTypeName)
        {
            bool status = false;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConfigConstant.StudentDBConnectionString);
                SqlCommand cmd = new SqlCommand(DbConstants.spRegister,con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", users.UserName);
                cmd.Parameters.AddWithValue("@Email", users.Email);
                cmd.Parameters.AddWithValue("@Password", users.Password);
                cmd.Parameters.AddWithValue("@UserTypeName", userTypeName);

                SqlParameter isRegistered = new SqlParameter();
                isRegistered.ParameterName = "@IsRegistered";
                isRegistered.SqlDbType = SqlDbType.Bit;
                isRegistered.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(isRegistered);

                con.Open();
                cmd.ExecuteNonQuery();

                status = (bool)isRegistered.Value;



            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return status;
        }

        public bool Login(string username,string password,out string role)
        {
            bool status = false;
            SqlConnection con = null;
            role = "Invalid";
            try
            {
                con = new SqlConnection(ConfigConstant.StudentDBConnectionString);
                SqlCommand cmd = new SqlCommand(DbConstants.spLogin, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);
                
                SqlParameter isLoginSuccess = new SqlParameter();
                isLoginSuccess.ParameterName = "@IsLoginSuccess";
                isLoginSuccess.SqlDbType = SqlDbType.Bit;
                isLoginSuccess.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(isLoginSuccess);

                SqlParameter roleName = new SqlParameter();
                roleName.ParameterName = "@RoleName";
                roleName.SqlDbType = SqlDbType.VarChar;
                roleName.Size = 50;
                roleName.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(roleName);
              

                con.Open();
                cmd.ExecuteNonQuery();

                role = roleName.Value.ToString();
                status = (bool)isLoginSuccess.Value;
                


            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return status;
        }
    }
}
