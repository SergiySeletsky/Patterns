using System;
using System.Data;
using System.Data.OleDb;

namespace Patterns.Behavioral.TemplateMethod
{
    internal class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            var dataAdapter = new OleDbDataAdapter(
                sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categories");
        }

        public override void Process()
        {
            Console.WriteLine("Categories ---- ");

            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }
    }
}