/*
 * TableDTO.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TableDTO
    {
        string _tableID;
        string _status;

        public string TableID { get => _tableID; set => _tableID = value; }
        public string Status { get => _status; set => _status = value; }

        public TableDTO()
        {
            _tableID = string.Empty;
            _status = string.Empty;
        }
    }
}
