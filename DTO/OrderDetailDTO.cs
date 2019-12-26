/*
 * OrderDetailDTO.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetailDTO
    {
        String _orderID;
        String _foodID;
        int _quantity;

        public string OrderID { get => _orderID; set => _orderID = value; }
        public string FoodID { get => _foodID; set => _foodID = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }

        public OrderDetailDTO()
        {
            _orderID = String.Empty;
            _foodID = String.Empty;
            _quantity = 0;
        }
    }
}
