using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD = System.Data;
using System.Windows.Forms;

namespace CLD
{
    class Getter
    {
        Conector conector = new Conector();
        SD.DataSet ds;
        public void table (string command) 
        {

            
            conector.OpenConnection();
            
            MySqlDataAdapter ms_data = new MySqlDataAdapter(command,conector._Uid());
           
            SD.DataTable table = new SD.DataTable();
            ms_data.Fill(table);


        }
        public void _Sql(string command)
        {

            //ModeBox.Items.AddRange(new string[] {"Search","Search where", "Update", "Removal","Search 2 tables","Insert" });
            switch (command)
              {
                    case "Search":
                        Bufer.sqlcomand =$"SELECT * FROM {Bufer.table_name};";
                    break;
                    case "Update":
                        Bufer.sqlcomand = $"UPDATE {Bufer.table_name}  SET {Bufer.table_Cells2} = '{Bufer.condition2}'  WHERE {Bufer.table_Cells} = '{Bufer.condition}'; SELECT * FROM {Bufer.table_name};";
                        
                    break;
                    case "Search where":
                        Bufer.sqlcomand  = $"SELECT * FROM {Bufer.table_name} WHERE {Bufer.table_Cells} = '{Bufer.condition}'";
                    break;
                    case "Insert":
                        Bufer.sqlcomand = $"INSERT INTO  {Bufer.table_name} ( {Bufer.table_Cells},{Bufer.table_Cells2})  VALUES ('{Bufer.condition}','{Bufer.condition2}');SELECT * FROM {Bufer.table_name};";
                    break;
                    case "Removal":
                    Bufer.sqlcomand = $"DELETE  FROM  {Bufer.table_name} WHERE {Bufer.table_Cells} ='{Bufer.condition}';SELECT * FROM {Bufer.table_name};";
                    break;
                    case "Search 2 tables":
                    Bufer.sqlcomand = $"SELECT * FROM {Bufer.table_name} WHERE  {Bufer.table_Cells} = (SELECT {Bufer.table_Cells2} FROM {Bufer.table_name2} WHERE {Bufer.helper} = '{Bufer.condition2}'); ;";
                    break;




            }
            
            
            
        }

    }
}
