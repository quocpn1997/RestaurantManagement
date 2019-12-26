/*
 * UserBUS.cs
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
    public class UserBUS
    {
        UserDTO userDTO = new UserDTO();
        UserDAO userDAO = new UserDAO();

        #region retrieve
        public int CountUserManager()
        {
            return userDAO.countByRoleManager();
        }

        public bool countByUsername(string username)
        {
            userDTO.Username = username;
            return userDAO.countByUsername(userDTO);
        }

        public DataTable SelectAllUsernameRoleGender()
        {
            return userDAO.selectAllUsernameRoleGender();
        }

        public bool SelectUserByUsernamePassword(String username, String password)
        {
            userDTO.Username = username;
            userDTO.Password = password;
            return userDAO.selectUserByUsernamePassword(userDTO);
        }

        public String SelectNameByUsername(String username)
        {
            userDTO.Username = username;
            return userDAO.selectNameByUsername(userDTO);
        }

        public String SelectRoleByUsername(String username)
        {
            userDTO.Username = username;
            return userDAO.selectRoleByUsername(userDTO);
        }

        public DataTable SelectUserByUsername(String username)
        {
            userDTO.Username = username;
            return userDAO.selecUserByUsername(userDTO);
        }
        #endregion

        #region insert
        public void InsertUserByUsernamePasswordRole(string username, string password, string role)
        {
            userDTO.Username = username;
            userDTO.Password = password;
            userDTO.Role = role;
            userDAO.insertUserByUsernamePasswordRole(userDTO);
        }
        #endregion

        #region update
        public int UpdateNameByUsername(string username, string name)
        {
            userDTO.Username = username;
            userDTO.Name = name;
            return userDAO.updateNameByUsername(userDTO);
        }

        public int UpdatePhoneByUsername(string username, string phone)
        {
            userDTO.Username = username;
            userDTO.Phone = phone;
            return userDAO.updatePhoneByUsername(userDTO);
        }

        public int UpdateAddressByUsername(string username, string address)
        {
            userDTO.Username = username;
            userDTO.Address = address;
            return userDAO.updateAddressByUsername(userDTO);
        }

        public int UpdateBirthdayByUsername(string username, string birthday)
        {
            userDTO.Username = username;
            userDTO.Birthday = birthday;
            return userDAO.updateBirthdayByUsername(userDTO);
        }

        public int UpdateRoleByUsername(string username, string role)
        {
            userDTO.Username = username;
            userDTO.Role = role;
            return userDAO.updateRoleByUsername(userDTO);
        }

        public int UpdateGenderByUsername(string username, bool gender)
        {
            userDTO.Username = username;
            userDTO.Gender = gender;
            return userDAO.updateGenderByUsername(userDTO);
        }
        #endregion

        #region delete
        public int DeleteUserByUsername(string username)
        {
            userDTO.Username = username;
            return userDAO.deleteUserByUsername(userDTO);
        }
        #endregion
    }
}
