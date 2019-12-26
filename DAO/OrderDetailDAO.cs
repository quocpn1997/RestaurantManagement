/*
 * OrderDetailDAO.cs
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
    public class OrderDetailDAO : DbConnection
    {
        SqlCommand cmd = new SqlCommand();

        #region retrieve
        public DataTable selectAllOrderDetailByOrderID(OrderDetailDTO orderDetailDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select FOODID, QUANTITY  from [ORDERDETAIL] where ORDERID = '" + orderDetailDTO.OrderID + "'";
            return ExeReader(cmd);
        }
        #endregion

        #region insert
        public int insertNewOrderDetail(OrderDetailDTO orderDetailDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [ORDERDETAIL] values ('" + orderDetailDTO.OrderID + "', '" + orderDetailDTO.FoodID + "', " + orderDetailDTO.Quantity.ToString() + ")";
            return ExeNonQuery(cmd);
        }
        #endregion

        #region delete
        public void deleteOrderDetailByFoodID(OrderDetailDTO orderDetailDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [ORDERDETAIL] where ORDERID = '" + orderDetailDTO.OrderID + "' and FOODID = '" + orderDetailDTO.FoodID + "'";
            ExeNonQuery(cmd);
        }
        #endregion

        #region update
        public void UpdateQuantityBy(OrderDetailDTO orderDetailDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [ORDERDETAIL] set QUANTITY = " + orderDetailDTO.Quantity.ToString() + " where ORDERID = '" + orderDetailDTO.OrderID + "' and FOODID = '" + orderDetailDTO.FoodID + "'";
            ExeNonQuery(cmd);
        }
        #endregion
    }
}
