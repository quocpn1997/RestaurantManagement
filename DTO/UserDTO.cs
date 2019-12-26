/*
 * UserDTO.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private string _Username;
        private string _Password;
        private string _Role;
        private string _Name;
        private bool _Gender;
        private string _Birthday;
        private string _Phone;
        private string _Address;

        public string Username { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Role { get => _Role; set => _Role = value; }
        public string Name { get => _Name; set => _Name = value; }
        public bool Gender { get => _Gender; set => _Gender = value; }
        public string Birthday { get => _Birthday; set => _Birthday = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string Address { get => _Address; set => _Address = value; }

        public UserDTO()
        {
            _Username = String.Empty;
            _Password = String.Empty;
            _Role = String.Empty;
            _Name = String.Empty;
            _Gender = false;
            _Birthday = String.Empty;
            _Phone = String.Empty;
            _Address = String.Empty;
        }
    }
}
