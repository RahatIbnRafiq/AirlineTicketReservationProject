import java.sql.*;

public class OracleConnect
{

        private Connection connection;
        private Statement stmt;
        private ResultSet rs;


        public OracleConnect(String host,String dbname,String username,String password)
        {
			String url="jdbc:oracle:thin:@//"+host+":1521/"+dbname;
			try
			{
				Class.forName("oracle.jdbc.OracleDriver");
				this.connection=DriverManager.getConnection(url,username,password);
				System.out.print("Connected\n");
			}
			catch(Exception e)
			{
			    System.out.println("In OracleConnect:OracleConnect - " + e);
			}
        }

        public int updateDB(String query)
        {
                int result = 0;
                try
                {
                        stmt=this.connection.createStatement();
                        result=this.stmt.executeUpdate(query);
                }
                catch (Exception e)
                {
                        result=-1;
                        System.out.println("In OracleConnect:updateDB - " + e);
                }
                return result;
        }

        public ResultSet searchDB(String query)
        {

                try
                {
                        stmt=connection.createStatement();
                        rs=stmt.executeQuery(query);
                }
                catch (Exception e)
                {

                        System.out.println("In OracleConnect:searchDB - " + e);
                }
                return rs;
        }
	

        public void close()
        {
                try
                {
                        connection.close();
                        System.out.println("Disconnected");
                }
                catch(Exception e)
                {
                        System.out.println("In OracleConnect:close - " + e);
                }

        }
        
        
        public Savepoint startTransaction()
        {
            try
            {
                    connection.setAutoCommit(false);
                    return connection.setSavepoint();
            }
            catch(Exception e)
            {
                    System.out.println("In OracleConnect:startTransaction - " + e);
            }
            return null;
        }

        public void finishTransaction()
        {
            try
            {
                connection.setAutoCommit(true);
                connection.commit();
            }
            catch(Exception e)
            {
               System.out.println("In OracleConnect:finishTransaction - " + e);
            }
        }

        public void abortTransaction(Savepoint sp)
        {
            try
            {
                connection.rollback(sp);
                connection.setAutoCommit(true);
                connection.commit();
            }
            catch(Exception e)
            {
               System.out.println("In OracleConnect:abortTransaction - " + e);
            }
        }
        
        
        

}




