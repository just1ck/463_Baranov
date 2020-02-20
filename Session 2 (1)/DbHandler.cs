using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using Receipts.receiptsDataSetTableAdapters;

namespace Receipts
{
    class DbHandler
    {
        //private string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Y:\\data\\programs\\GitKaraken\\DemoExamCSharp\\DemoExamCSharp\\Receipts\\db";
        receiptsDataSet ds;
        public enum TableNames {
            Food = 0,
            HowToPrepare = 1,
            MeasurementUnits = 2,
            PartsOfFood = 3
        }

        public DbHandler()
        {
            ds = new receiptsDataSet();
        }

        public List<List<string>> read(int tableName)
        {
            List<List<string>> result = new List<List<string>>();

            DataTableReader dtr = ds.Tables[tableName].CreateDataReader();
            //DataTableReader dtr = ds.Tables[tableName].Rows.;
            for (int j = 0; j < ds.Tables[tableName].Rows.Count; j++)
            {
                List<string> currentItem = new List<string>();
                for (int i = 0; i < ds.Tables[tableName].Columns.Count; i++)
                {
                    currentItem.Add(ds.Tables[tableName].Rows[i][j].ToString());
                }
                result.Add(currentItem);
            }

            /*List<string> voidItem = new List<string>();
            foreach (DataRow dr in ds.Tables[tableName].Rows)
            {
                List<string> lastItem = voidItem;
                foreach(DataColumn dc in ds.Tables[tableName].Columns)
                {
                    lastItem.Add(dr[dc].ToString());
                }
                result.Add(lastItem);
            }*/
            return result;
        }
    }
}
