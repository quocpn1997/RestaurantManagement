/*
 * FoodDTO.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodDTO
    {
        String _foodID;
        String _name;
        int _price;

        public string FoodID { get => _foodID; set => _foodID = value; }
        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public FoodDTO()
        {
            _foodID = String.Empty;
            _name = String.Empty;
            _price = 0;
        }
    }
}
