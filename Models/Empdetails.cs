using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace EmpCRUD_07_09_24.Models
{
    public class Empdetails
    {
        public int empid { set; get; }
        public string Ename { set; get; }
        public string designation { set; get; }
        public DateTime DOJ { set; get; }
        public double Salary { set; get; }
        public int Deptno { set; get; }
    }
        public class Empopeartion
        {
            SqlConnection con=new SqlConnection(@"Data Source=SUSHANT\MSSQLSERVER01;Initial Catalog=Aspconnectivity;Integrated Security=True;Encrypt=False");
            SqlCommand cmd;
            string Query;
            public int AddEmp(Empdetails E)
            {
                Query = "insert into Empdetails values(@p1,@p2,@p3,@p4,@p5,@p6)";
                cmd=new SqlCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1",E.empid);
                cmd.Parameters.AddWithValue("@p2", E.Ename);
                cmd.Parameters.AddWithValue("@p3",E.designation);
                cmd.Parameters.AddWithValue("@p4",E.DOJ);
                cmd.Parameters.AddWithValue("@p5",E.Salary);
                cmd.Parameters.AddWithValue("@p6",E.Deptno);
                con.Open();
                int r=cmd.ExecuteNonQuery();
                con.Close();
                return r;
            }
            public int UpdateEmp(Empdetails E)
            {
                Query = "update Empdetails set Ename=@p2,designation=@p3,DOJ=@p4,Salary=@p5,Deptno=@p6 where empid=@p1";
                cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", E.empid);
                cmd.Parameters.AddWithValue("@p2", E.Ename);
                cmd.Parameters.AddWithValue("@p3", E.designation);
                cmd.Parameters.AddWithValue("@p4", E.DOJ);
                cmd.Parameters.AddWithValue("@p5", E.Salary);
                cmd.Parameters.AddWithValue("@p6", E.Deptno);
                con.Open();
                int r=cmd.ExecuteNonQuery();
                con.Close();
                return r;
            }
            public int DeleteEmp(int Id)
            {
                Query = "Delete Empdetails where empid=@p1";
                cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", Id);
                con.Open();
                int r=cmd.ExecuteNonQuery();
                con.Close();
                return r;
            }
        }
    }
