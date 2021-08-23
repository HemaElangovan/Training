using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcRegistrationTask.Models
{
    public class RegisterModel
    {
        SqlConnection con;
        public RegisterModel()
    {
        con = new SqlConnection("Data Source=HEMA-E; Database =RegistrationDb;User ID=sa;Password=sasa@123");
    }
        public DataTable GetData()
        {
            string str = "select Rno, FirstName, LastName, Age, Gender from tbl_RegisterForm";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int InsertData(string fn, string ln, int age, string gender)
        {
            string insert = "insert into tbl_RegisterForm(FirstName, LastName, Age, Gender) values (@fn,@ln,@age,@gender)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender", gender);
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable Edit(int rno)
        {
            string dataedit = "select Rno,FirstName,LastName,Age,Gender from tbl_RegisterForm where Rno=" + rno;
            SqlDataAdapter da = new SqlDataAdapter(dataedit, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int EditData(int rno, string fn, string ln, int age,string gender)
        {
            string up = "update tbl_RegisterForm set FirstName=@fn, LastName=@ln, Age=@age, Gender=@gender where Rno=@rno";
            SqlCommand cmd = new SqlCommand(up, con);
            cmd.Parameters.AddWithValue("@rno", rno);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender", gender);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

    }
}