using MobileStore.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DAL.ResponseCreation
{
    public class ResponseCreations : IResponseCreations
    {
        private SqlConnection con;

        public bool RegisterUser(UserRegistration er)
        {
            int Flag = (int)Months.Create;
            string constring = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
            con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("EmployeeCRUDOperation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmailId", er.Email);
            cmd.Parameters.AddWithValue("@Password", er.Password);
            cmd.Parameters.AddWithValue("@Id", er.Id);
            cmd.Parameters.AddWithValue("@Flag", Flag);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool RegisterLogin(UserRegistration er)
        {
            int Flag = (int)Months.Create;
            string constring = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
            con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("EmployeeCRUDOperation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmailId", er.Email);
            cmd.Parameters.AddWithValue("@Password", er.Password);
            cmd.Parameters.AddWithValue("@Id", er.Id);
            cmd.Parameters.AddWithValue("@Flag", Flag);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return true;
            }
            return false;
        }
    }
}
