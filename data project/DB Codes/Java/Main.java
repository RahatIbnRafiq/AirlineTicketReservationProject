import java.sql.*;


public class Main
{
	public static void main(String args[])
	{
		try
		{
			OracleConnect dbc=new OracleConnect("localhost","orcl","rifat","0105037");
			ResultSet rs=dbc.searchDB("select * from lib_book");
			while(rs.next())
			{
				System.out.print("BookId:"+rs.getInt("BookId"));
				System.out.print("  ");
				System.out.print("Title:"+rs.getString("Title"));
				System.out.println();
			}
			dbc.updateDB("update lib_book set title='C' where bookid=5");
			
		}catch(Exception e)
		{
		}
	}
	
}
	