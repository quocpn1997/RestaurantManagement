/*
 * FoodBUS.cs
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
    public class FoodBUS
    {
        FoodDTO foodDTO = new FoodDTO();
        FoodDAO foodDAO = new FoodDAO();

        #region retrive
        public DataTable selectAllFoodIDName()
        {
            return foodDAO.selectAllFoodIDName();
        }

        public DataTable selectAllFoodName()
        {
            return foodDAO.selectAllFoodName();
        }

        public String selectPriceByID(String foodID)
        {
            foodDTO.FoodID = foodID;
            return foodDAO.selectPriceByID(foodDTO);
        }

        public String selectNameByFoodID(String foodID)
        {
            foodDTO.FoodID = foodID;
            return foodDAO.selectNameByFoodID(foodDTO);
        }
        #endregion

        #region delete
        public void RemoveFoodByFoodName(String foodName)
        {
            foodDTO.Name = foodName;
            foodDAO.RemoveFoodByFoodName(foodDTO);
        }
        #endregion

        #region insert
        public void AddFood(String foodName, int price)
        {
            foodDTO.Name = foodName;
            foodDTO.Price = price;
            foodDAO.AddFood(foodDTO);
        }
        #endregion
    }
}
