/*
 * OrderDTO.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDTO
    {
        String _orderID;
        String _tableID;
        DateTime _time;
        String _status;
        int _total;

        public string OrderID { get => _orderID; set => _orderID = value; }
        public string TableID { get => _tableID; set => _tableID = value; }
        public DateTime Time { get => _time; set => _time = value; }
        public string Status { get => _status; set => _status = value; }
        public int Total { get => _total; set => _total = value; }

        public OrderDTO()
        {
            _orderID = String.Empty;
            _tableID = String.Empty;
            _time = DateTime.Today;
            _status = String.Empty;
            _total = 0;
        }
    }
}
