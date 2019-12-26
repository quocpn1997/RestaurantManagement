/*
 * OrderDAO.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class OrderDAO : DbConnection
    {
        SqlCommand cmd = new SqlCommand();

        #region retrive
        public DataTable selectOrderByTableIDStatus(OrderDTO orderDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [ORDER] where TABLEID = '" + orderDTO.TableID + "' and STATUS = 'Eating'";
            return ExeReader(cmd);
        }

        public String selectOrderIDByTableID(OrderDTO orderDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ORDERID from [ORDER] where TABLEID = '" + orderDTO.TableID + "' and STATUS = 'Eating'";
            if (ExeScalar(cmd) != null)
            {
                return ExeScalar(cmd).ToString();
            }
            else
            {
                return "0";
            }
        }

        public DataTable selectAll()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ORDERID, TABLEID, convert(varchar(10), TIME, 103), STATUS, TOTAL from [ORDER]";
            return ExeReader(cmd);
        }

        public DataTable selectAllByOrderID(OrderDTO orderDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ORDERID, TABLEID, convert(varchar(10), TIME, 103), STATUS, TOTAL from [ORDER] where ORDERID = '" + orderDTO.OrderID + "'";
            return ExeReader(cmd);
        }

        public DataTable selectAllByTable(OrderDTO orderDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ORDERID, TABLEID, convert(varchar(10), TIME, 103), STATUS, TOTAL from [ORDER] where TABLEID = '" + orderDTO.TableID + "'";
            return ExeReader(cmd);
        }

        public DataTable selectAllByTime(String time)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ORDERID, TABLEID, convert(varchar(10), TIME, 103), STATUS, TOTAL from [ORDER] where TIME = convert(date, '" + time + "', 103)";
            return ExeReader(cmd);
        }

        public String selectSumTotalByMonth(int month)
        {
            string monthTemp = month.ToString();
            if (month < 10)
            {
                monthTemp = "0" + monthTemp;
            }

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select sum(TOTAL) from [ORDER] where TIME >= convert(date, '01/" + monthTemp + "/2018', 103) and TIME <= convert(date, '28/" + monthTemp + "/2018', 103)";
            return ExeScalar(cmd).ToString();

        }
        #endregion

        #region insert
        public int insertNewOrder(OrderDTO orderDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [ORDER](TABLEID, STATUS) values ('" + orderDTO.TableID + "', 'Eating')";
            return ExeNonQuery(cmd);
        }
        #endregion

        #region delete
        public void deleteOrderByOrderID(OrderDTO orderDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [ORDER] where ORDERID = '" + orderDTO.OrderID + "'";
            ExeNonQuery(cmd);
        }
        #endregion

        #region update
        public void updateDoneStatus(OrderDTO orderDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [ORDER] set STATUS = 'Done' where ORDERID = '" + orderDTO.OrderID + "'";
            ExeNonQuery(cmd);
        }

        public void updateTotal(OrderDTO orderDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [ORDER] set TOTAL = '" + orderDTO.Total.ToString() + "' where ORDERID = '" + orderDTO.OrderID + "'";
            ExeNonQuery(cmd);
        }

        public void updateTime(OrderDTO orderDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [ORDER] set TIME= convert(date, '" + orderDTO.Time.ToString("dd/MM/yyyy") + "', 103) where ORDERID = '" + orderDTO.OrderID + "'";
            ExeNonQuery(cmd);
        }
        #endregion
    }
}
