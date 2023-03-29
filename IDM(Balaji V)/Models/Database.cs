using System;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using IdentityManagement.Models;
using System.Data;

namespace IdentityManagement.Models{
    public class Database{
        static SqlConnection sqlconnection=new SqlConnection("data source=DESKTOP-8ERMIG4\\SQLEXPRESS;initial catalog=identityManagement;trusted_connection=true");

        static public string EmployeeLogin(User user)
        {
                
                sqlconnection.Open();
                SqlCommand command=new SqlCommand("VerifyUser",sqlconnection); 
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmailId",user.EmailId);
                command.Parameters.AddWithValue("@userPassword", user.userPassword);
                int Count=Convert.ToInt32(command.ExecuteScalar());
                sqlconnection.Close();
                if(Count==1)
                {
                  return "success";         
                }
                
                  return "fails";
                
                     
    }
    static public string AdminLogin(User user)
        {
                
                sqlconnection.Open();
                SqlCommand command=new SqlCommand("VerifyAdmin",sqlconnection); 
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmailId",user.EmailId);
                command.Parameters.AddWithValue("@userPassword", user.userPassword);
                int Count=Convert.ToInt32(command.ExecuteScalar());
                sqlconnection.Close();
                if(Count==1)
                {
                  return "success";         
                }
                
                  return "fails";
                
                     
    }
}
}