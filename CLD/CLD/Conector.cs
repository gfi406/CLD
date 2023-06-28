using MySqlConnector;

namespace CLD
{
  public class Conector
  {

            public void OpenConnection()
            {
                
                MySqlConnection conn = new MySqlConnection(_Uid());
                conn.Open();
            }
        

            public void CloseConnection()
            {
                 MySqlConnection conn = new MySqlConnection();
                 conn.Close();
            }
            public string _Uid()
            {
                string server = "127.0.0.1";
                string port = "3306";
                string database = "chair_load";
                string uid = "GIF";
                string password = "Nfubk111!";
                string connectionString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};charset=utf8";
                return connectionString;
        
            }

  }
    

    


        
    
}
