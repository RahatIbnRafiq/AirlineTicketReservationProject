using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Data.OracleClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
        OracleConnect oc = new OracleConnect("localhost", "orcl", "rahat", "maldini");
        String s1 = "flight";
        DataTable table = oc.searchDB("select * from "+s1);

        this.GridView1.DataSource = table;
        this.GridView1.DataBind();

        /*foreach (DataRow dr in table.Rows)
        {
            Label1.Text = Label1.Text + dr["name"] + " ";
        } */

    }
}

public class OracleConnect
{
    string connectionString;
    private System.Data.OracleClient.OracleConnection connection;
    private System.Data.OracleClient.OracleDataAdapter adapter;
    private System.Data.OracleClient.OracleCommand command;


    public OracleConnect(string host, string dbname, string username, String password)
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