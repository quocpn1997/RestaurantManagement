/*
 * DbConnection.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DbConnection
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5ELO0T6\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");

        public SqlConnection getCon()  //to check whether the DB connectiong is open
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int ExeNonQuery(SqlCommand cmd)  //to perform Insert, Update, Delete
        {
            cmd.Connection = getCon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }

        public object ExeScalar(SqlCommand cmd)  //to retrieve a single value from DB or Query
        {
            cmd.Connection = getCon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        public DataTable ExeReader(SqlCommand cmd)  //to perform Select Query
        {
            cmd.Connection = getCon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
    }
}
