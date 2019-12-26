/*
 * TableDAO.cs
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
    public class TableDAO : DbConnection
    {
        SqlCommand cmd = new SqlCommand();

        #region retrive
        public DataTable selectAllTable()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [TABLE]";
            return ExeReader(cmd);
        }

        public String CountTable()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from [TABLE]";
            return ExeScalar(cmd).ToString();
        }
        #endregion

        #region update
        public void UpdateStatusToFull(TableDTO tableDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update [TABLE] set STATUS = 'Full' where TABLEID = '" + tableDTO.TableID + "'";
            ExeNonQuery(cmd);
        }

        public void UpdateStatusToEmpty(TableDTO tableDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update [TABLE] set STATUS = 'Empty' where TABLEID = '" + tableDTO.TableID + "'";
            ExeNonQuery(cmd);
        }
        #endregion

        #region insert
        public void insertTable(TableDTO tableDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [TABLE] values ('" + tableDTO.TableID + "', 'Empty')";
            ExeNonQuery(cmd);
        }
        #endregion

        #region delete
        public void deleteTable(TableDTO tableDTO)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [TABLE] where TABLEID = '" + tableDTO.TableID + "'";
            ExeNonQuery(cmd);
        }
        #endregion
    }
}
