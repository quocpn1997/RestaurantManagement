/*
 * TableBUS.cs
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
    public class TableBUS
    {
        TableDTO tableDTO = new TableDTO();
        TableDAO tableDAO = new TableDAO();

        #region retrive
        public DataTable SelectAllTable()
        {
            return tableDAO.selectAllTable();
        }

        public String CountTable()
        {
            return tableDAO.CountTable();
        }
        #endregion

        #region update
        public void UpdateStatusToFull(String tableID)
        {
            tableDTO.TableID = tableID;
            tableDAO.UpdateStatusToFull(tableDTO);
        }

        public void UpdateStatusToEmpty(String tableID)
        {
            tableDTO.TableID = tableID;
            tableDAO.UpdateStatusToEmpty(tableDTO);
        }
        #endregion

        #region insert
        public void insertTable(String tableID)
        {
            tableDTO.TableID = tableID;
            tableDAO.insertTable(tableDTO);
        }
        #endregion

        #region delete
        public void deleteTable(String tableID)
        {
            tableDTO.TableID = tableID;
            tableDAO.deleteTable(tableDTO);
        }
        #endregion
    }
}
