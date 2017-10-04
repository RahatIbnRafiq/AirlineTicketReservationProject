using System;
using System.Data;
using System.Data.OracleClient;

namespace OracleConnection
{
    public class OracleConnect
    {
        string connectionString;
        private System.Data.OracleClient.OracleConnection connection;
        private System.Data.OracleClient.OracleDataAdapter adapter;
        private System.Data.OracleClient.OracleCommand command;
       

        public OracleConnect(string host,string dbname, string username, String password)
        {
            try
            {
            	//this.connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST="+host+")(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME="+dbname+")));User Id="+username+";Password="+password+";";
            	this.connectionString = "User id=" + username + ";Password=" + password + ";Data Source=" + dbname;
                this.connection = new System.Data.OracleClient.OracleConnection(this.connectionString);
                this.connection.Open();
                this.command = connection.CreateCommand();
                Console.WriteLine("Connected");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while connecting:" + e.Message);
            }

        }

        public DataTable searchDB(string query)
        {
            DataTable table = new DataTable();
            try
            {
                this.command.CommandText = query;              
                this.adapter = new System.Data.OracleClient.OracleDataAdapter(command);               
                this.adapter.Fill(table);                
            }
            catch (Exception e)
            {
                Console.Write("Error:" + e);
            }
            return table; 
        }


        public DataSet searchDBSet(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                this.command.CommandText = query;
                this.adapter = new System.Data.OracleClient.OracleDataAdapter(command);                             
                this.adapter.Fill(ds);                
            }
            catch (Exception e)
            {
                Console.Write("Error:" + e);
            }
            return ds;
        }

        public int updateDB(string query)
        {
            try
            {
                this.command.CommandText = query;
                return this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write("Error:" + e);
                return -1;
            }
        }

       
        public void close()
        {
            connection.Close();
        }

       

    }
}
