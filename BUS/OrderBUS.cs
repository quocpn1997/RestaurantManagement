/*
 * OrderBUS.cs
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
    public class OrderBUS
    {
        OrderDTO orderDTO = new OrderDTO();
        OrderDAO orderDAO = new OrderDAO();

        #region retrive
        public DataTable selectOrderByTableIDStatus(String tableID)
        {
            orderDTO.TableID = tableID;
            return orderDAO.selectOrderByTableIDStatus(orderDTO);
        }

        public String selectOrderIDByTableID(String tableID)
        {
            orderDTO.TableID = tableID;
            return orderDAO.selectOrderIDByTableID(orderDTO);
        }

        public DataTable selectAll()
        {
            return orderDAO.selectAll();
        }

        public DataTable selectAllByOrderID(String orderID)
        {
            orderDTO.OrderID = orderID;
            return orderDAO.selectAllByOrderID(orderDTO);
        }

        public DataTable selectAllByTable(String tableID)
        {
            orderDTO.TableID = tableID;
            return orderDAO.selectAllByTable(orderDTO);
        }

        public DataTable selectAllByTime(String time)
        {
            return orderDAO.selectAllByTime(time);
        }

        public String selectSumTotalByMonth(int month)
        {
            return orderDAO.selectSumTotalByMonth(month);
        }
        #endregion

        #region insert
        public int insertNewOrder(String tableID)
        {
            orderDTO.TableID = tableID;
            return orderDAO.insertNewOrder(orderDTO);
        }
        #endregion

        #region delete
        public void deleteOrderByOrderID(String orderID)
        {
            orderDTO.OrderID = orderID;
            orderDAO.deleteOrderByOrderID(orderDTO);
        }
        #endregion

        #region update
        public void updateDoneStatus(string orderID)
        {
            orderDTO.OrderID = orderID;
            orderDAO.updateDoneStatus(orderDTO);
        }

        public void updateTotal(string orderID, int total)
        {
            orderDTO.OrderID = orderID;
            orderDTO.Total = total;
            orderDAO.updateTotal(orderDTO);
        }

        public void updateTime()
        {
            orderDTO.Time = DateTime.Today;
            orderDAO.updateTime(orderDTO);
        }
        #endregion
    }
}
