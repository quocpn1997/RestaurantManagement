/*
 * UserDAO.cs
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
    public class UserDAO : DbConnection
    {
        SqlCommand cmd = new SqlCommand();

        #region retrieve
        public int countByRoleManager()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from [USER] where ROLE = 'manager'";
            return Convert.ToInt32(ExeScalar(cmd));
        }

        public bool countByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from [USER] where USERNAME = '" + userDTO.Username + "'";
            if(Convert.ToInt32(ExeScalar(cmd)) > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable selectAllUsernameRoleGender()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select USERNAME, ROLE, GENDER from [USER]";
            return ExeReader(cmd);
        }

        public bool selectUserByUsernamePassword(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [USER] where USERNAME='" + userDTO.Username + "' and PASSWORD = '" + userDTO.Password + "'";

            if(ExeScalar(cmd) != null)
            {
                return true;
            }
            return false;
        }

        public String selectNameByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select NAME from [USER] where USERNAME='" + userDTO.Username + "'";
            return ExeScalar(cmd).ToString();
        }

        public String selectRoleByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ROLE from [USER] where USERNAME='" + userDTO.Username + "'";
            return ExeScalar(cmd).ToString();
        }

        public DataTable selecUserByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select NAME, convert(varchar(10), BIRTHDAY, 103), PHONE, ADDRESS, GENDER, ROLE from [USER] where USERNAME = '" + userDTO.Username + "'";
            return ExeReader(cmd);
        }
        #endregion

        #region insert
        public int insertUserByUsernamePasswordRole(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [USER](USERNAME, PASSWORD, ROLE) values ('" + userDTO.Username + "', '" + userDTO.Password + "', '" + userDTO.Role + "')";
            return ExeNonQuery(cmd);
        }
        #endregion

        #region update
        public int updateNameByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [USER] set NAME = '" + userDTO.Name + "' where USERNAME = '" + userDTO.Username + "'";
            return ExeNonQuery(cmd);
        }

        public int updatePhoneByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [USER] set PHONE = '" + userDTO.Phone + "' where USERNAME = '" + userDTO.Username + "'";
            return ExeNonQuery(cmd);
        }

        public int updateAddressByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [USER] set ADDRESS = '" + userDTO.Address + "' where USERNAME = '" + userDTO.Username + "'";
            return ExeNonQuery(cmd);
        }

        public int updateBirthdayByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [USER] set BIRTHDAY = convert(date, '" + userDTO.Birthday + "', 103) where USERNAME = '" + userDTO.Username + "'";
            return ExeNonQuery(cmd);
        }

        public int updateRoleByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [USER] set ROLE = '" + userDTO.Role + "' where USERNAME = '" + userDTO.Username + "'";
            return ExeNonQuery(cmd);
        }

        public int updateGenderByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [USER] set GENDER = '" + userDTO.Gender + "' where USERNAME = '" + userDTO.Username + "'";
            return ExeNonQuery(cmd);
        }
        #endregion

        #region delete
        public int deleteUserByUsername(UserDTO userDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [USER] where USERNAME = '" + userDTO.Username + "'";
            return ExeNonQuery(cmd);
        }
        #endregion
    }
}
