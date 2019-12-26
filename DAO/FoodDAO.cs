/*
 * FoodDAO.cs
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
    public class FoodDAO : DbConnection
    {
        SqlCommand cmd = new SqlCommand();

        #region retrive
        public DataTable selectAllFoodIDName()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select FOODID, NAME from [FOOD]";
            return ExeReader(cmd);
        }

        public DataTable selectAllFoodName()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select NAME from [FOOD]";
            return ExeReader(cmd);
        }

        public String selectPriceByID(FoodDTO foodDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select PRICE from [FOOD] where FOODID = '" + foodDTO.FoodID + "'";
            return ExeScalar(cmd).ToString();
        }

        public String selectNameByFoodID(FoodDTO foodDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select NAME from [FOOD] where FOODID = '" + foodDTO.FoodID + "'";
            return ExeScalar(cmd).ToString();
        }
        #endregion

        #region delete
        public void RemoveFoodByFoodName(FoodDTO foodDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [FOOD] where NAME = '" + foodDTO.Name + "'";
            ExeNonQuery(cmd);
        }
        #endregion

        #region insert
        public void AddFood(FoodDTO foodDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [FOOD] values ('" + foodDTO.Name + "', " + foodDTO.Price.ToString() + ")";
            ExeNonQuery(cmd);
        }
        #endregion
    }
}
