using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pos_with_points.Classes
{
    public class DatabaseClass
    {
        private SqlConnection c_Connection = new SqlConnection(@"Data Source=DESKTOP-FV3MKIT\SQL;Initial Catalog=DB_POS_w_Points;User ID=sa;Password=123456");
        private SqlCommand c_Command = new SqlCommand();
        private SqlDataAdapter c_DataAdapter = new SqlDataAdapter();
        private DataTable c_DataTable = new DataTable();

        private string c_Columname;
        private string c_Values;

        private string c_UpdateColumn;
        private string c_WhereClause;


        public DataTable getdata(string databaseTable, string tableId)
        {
            c_DataTable = new DataTable();

            c_Connection.Open();
            c_DataAdapter = new SqlDataAdapter("Select * from " + databaseTable + " ORDER BY " + tableId + " DESC ", c_Connection);
            c_DataAdapter.SelectCommand.ExecuteNonQuery();
            c_DataAdapter.Fill(c_DataTable);
            c_Connection.Close();

            return c_DataTable;
        }
        public DataTable getdataRestricted(string databaseTable, string whereClause)
        {
            c_DataTable = new DataTable();

            c_Connection.Open();
            c_DataAdapter = new SqlDataAdapter("Select * from " + databaseTable + " where " + whereClause, c_Connection);
            c_DataAdapter.SelectCommand.ExecuteNonQuery();
            c_DataAdapter.Fill(c_DataTable);
            c_Connection.Close();

            return c_DataTable;
        }

        public DataTable getProdPurchase(string databaseTable, string whereClause)
        {
            c_DataTable = new DataTable();

            c_Connection.Open();
            c_DataAdapter = new SqlDataAdapter("Select * from " + databaseTable + " where " + whereClause, c_Connection);
            c_DataAdapter.SelectCommand.ExecuteNonQuery();
            c_DataAdapter.Fill(c_DataTable);
            c_Connection.Close();

            return c_DataTable;
        }

        public DataTable getSpecificData(string dbTable, string whereClause)
        {
            c_DataTable = new DataTable();

            c_Connection.Open();
            c_DataAdapter = new SqlDataAdapter("Select * from " + dbTable + " where " + whereClause, c_Connection);
            c_DataAdapter.SelectCommand.ExecuteNonQuery();
            // IDstore = c_DataAdapter
            c_DataAdapter.Fill(c_DataTable);
            c_Connection.Close();

            return c_DataTable;
        }


        public DataTable getTransactionLine(string whereClause)
        {
            c_DataTable = new DataTable();

            c_Connection.Open();
            c_DataAdapter = new SqlDataAdapter(" Select * from TB_SalesTransaction trans "
                        + " inner join TB_SalesTransactionLine line on line.sales_id = trans.sales_id "
                        + " inner join TB_Product prod on prod.product_id = line.product_id "
                        + " where trans.sales_id = " + whereClause, c_Connection);
            c_DataAdapter.SelectCommand.ExecuteNonQuery();
            c_DataAdapter.Fill(c_DataTable);
            c_Connection.Close();

            return c_DataTable;
        }

        public string get_value(string dbTable, string dbColumn, string whereClause)
        {
            string VALUE;
            object obj;
            c_Connection.Open();
            c_Command = new SqlCommand("Select " + dbColumn + " from " + dbTable + " where " + whereClause, c_Connection);
            Console.WriteLine("Select " + dbColumn + " from " + dbTable + " where " + whereClause);

            c_Command.CommandType = CommandType.Text;
            obj = c_Command.ExecuteScalar();
            c_Connection.Close();

            if (obj == null)
                VALUE = "";
            else
                VALUE = obj.ToString();

            return VALUE;
        }

        public void AddRecord(string databaseTable)
        {
            string sqlQry = "insert into " + databaseTable + "(" + c_Columname + ") values (" + c_Values + ")";
            c_Connection.Open();
            c_Command = new SqlCommand(sqlQry, c_Connection);
            c_Command.ExecuteNonQuery();
            c_Connection.Close();
        }
        public void setColumn(string columnName)
        {
            if (c_Columname == string.Empty)
                c_Columname = columnName;
            else
                c_Columname = c_Columname + ", " + columnName;
        }

        public void setValues(string val)
        {
            if (c_Values == string.Empty)
                c_Values = "'" + val + "'";
            else
                c_Values = c_Values + ", '" + val + "'";
        }
        public void updateRecords(string dbTable)
        {
            c_Connection.Open();
            c_Command = new SqlCommand("Update " + dbTable + " set " + c_UpdateColumn + " where " + c_WhereClause, c_Connection);
            c_Command.ExecuteNonQuery();
            c_Connection.Close();
        }
        public void SetColumnUpdateRecord(string columnName, string columnValue)
        {
            if (c_UpdateColumn == string.Empty)
                c_UpdateColumn = columnName + "= '" + columnValue + "'";
            else
                c_UpdateColumn += ", " + columnName + "= '" + columnValue + "'";
        }

        public void setwhereClause(string value)
        {
            c_WhereClause = value;
        }
        public void clearItems()
        {
            c_Columname = string.Empty;
            c_Values = string.Empty;
            c_UpdateColumn = string.Empty;
            c_WhereClause = string.Empty;
        }

        public void DeleteRecords(string dbTable, string whereclause)
        {
            c_Connection.Open();
            c_Command = new SqlCommand("Delete from " + dbTable + " where " + whereclause, c_Connection);
            c_Command.ExecuteNonQuery();
            c_Connection.Close();
        }

        public DataTable searchData(string databaseTable, string whereClause)
        {
            c_DataTable = new DataTable();

            c_Connection.Open();
            c_DataAdapter = new SqlDataAdapter("Select * from " + databaseTable + " where " + whereClause, c_Connection);
            c_DataAdapter.SelectCommand.ExecuteNonQuery();
            c_DataAdapter.Fill(c_DataTable);
            c_Connection.Close();

            return c_DataTable;
        }
    }

}
