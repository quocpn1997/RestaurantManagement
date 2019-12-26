/*
 * OrderDetailBUS.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class OrderDetailBUS
    {
        OrderDetailDTO orderDetailDTO = new OrderDetailDTO();
        OrderDetailDAO orderDetailDAO = new OrderDetailDAO();

        #region retrieve
        public DataTable selectAllOrderDetailByOrderID(String orderID)
        {
            orderDetailDTO.OrderID = orderID;
            return orderDetailDAO.selectAllOrderDetailByOrderID(orderDetailDTO);
        }
        #endregion

        #region insert
        public int insertNewOrderDetail(string orderID, string foodID, int quantity)
        {
            orderDetailDTO.OrderID = orderID;
            orderDetailDTO.FoodID = foodID;
            orderDetailDTO.Quantity = quantity;
            return orderDetailDAO.insertNewOrderDetail(orderDetailDTO);
        }
        #endregion

        #region delete
        public void deleteOrderDetailByFoodID(String orderID, String foodID)
        {
            orderDetailDTO.OrderID = orderID;
            orderDetailDTO.FoodID = foodID;
            orderDetailDAO.deleteOrderDetailByFoodID(orderDetailDTO);
        }
        #endregion

        #region update
        public void UpdateQuantityBy(String orderID, String foodID, int quantity)
        {
            orderDetailDTO.OrderID = orderID;
            orderDetailDTO.FoodID = foodID;
            orderDetailDTO.Quantity = quantity;
            orderDetailDAO.UpdateQuantityBy(orderDetailDTO);
        }
        #endregion
    }
}