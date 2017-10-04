// Fig. 21.16: Reservation.asmx.cs
// Airline reservation Web Service.

using System;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;

namespace AirlineReservation
{   
   // performs reservation of a seat
   [ WebService( Namespace = "http://www.deitel.com/csphtp1/ch21/",
        Description = "Service that enables a user to " +
        "reserve a seat on a plane." ) ]
   public class Reservation : System.Web.Services.WebService
   {
      private System.Data.OleDb.OleDbCommand 
         oleDbSelectCommand1;
      private System.Data.OleDb.OleDbCommand 
         oleDbInsertCommand1;
      private System.Data.OleDb.OleDbCommand 
         oleDbUpdateCommand1;
      private System.Data.OleDb.OleDbCommand 
         oleDbDeleteCommand1;
      private System.Data.OleDb.OleDbConnection 
         oleDbConnection1;
      private System.Data.OleDb.OleDbDataAdapter 
         oleDbDataAdapter1;

      public Reservation()
      {
         InitializeComponent();
      }

      #region Component Designer generated code
      private void InitializeComponent()
      {
         this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
         this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
         this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
         // 
         // oleDbUpdateCommand1
         // 
         this.oleDbUpdateCommand1.CommandText = "UPDATE Seats SET Class = ?, [Number] = ?, Taken = ?, Type = ? WHERE ([Number] = ?" +
            ") AND (Class = ?) AND (Taken = ?) AND (Type = ?)";
         this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Class", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Class", System.Data.DataRowVersion.Current, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Number", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Number", System.Data.DataRowVersion.Current, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Taken", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Taken", System.Data.DataRowVersion.Current, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Current, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Number", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Number", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Class", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Class", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Taken", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Taken", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbConnection1
         // 
         this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Inetpub\wwwroot\AirlineReservation\Tickets.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
         // 
         // oleDbInsertCommand1
         // 
         this.oleDbInsertCommand1.CommandText = "INSERT INTO Seats(Class, [Number], Taken, Type) VALUES (?, ?, ?, ?)";
         this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Class", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Class", System.Data.DataRowVersion.Current, null));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Number", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Number", System.Data.DataRowVersion.Current, null));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Taken", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Taken", System.Data.DataRowVersion.Current, null));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Current, null));
         // 
         // oleDbDeleteCommand1
         // 
         this.oleDbDeleteCommand1.CommandText = "DELETE FROM Seats WHERE ([Number] = ?) AND (Class = ?) AND (Taken = ?) AND (Type " +
            "= ?)";
         this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Number", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Number", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Class", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Class", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Taken", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Taken", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.Char, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbDataAdapter1
         // 
         this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
         this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
         this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
         this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                    new System.Data.Common.DataTableMapping("Table", "Seats", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("Number", "Number"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("Type", "Type"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("Class", "Class"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("Taken", "Taken")})});
         this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
         // 
         // oleDbSelectCommand1
         // 
         this.oleDbSelectCommand1.CommandText = "SELECT Class, [Number], Taken, Type FROM Seats";
         this.oleDbSelectCommand1.Connection = this.oleDbConnection1;

      }
      #endregion

      // checks database to determine whether
      // matching seat is available
      [ WebMethod ( Description = "Method to reserve seat." ) ]
      public bool Reserve( string seatType, string classType )
      {
         OleDbDataReader dataReader;
         
         // try database connection
         try 
         {
            // open database connection
            oleDbConnection1.Open();

            // set and execute SQL query
            oleDbDataAdapter1.SelectCommand.CommandText =
               "SELECT Number FROM Seats WHERE Type = '" +
               seatType + "' AND Class = '" + classType + 
               "' AND Taken = '0'" ;
            dataReader = 
               oleDbDataAdapter1.SelectCommand.ExecuteReader();

            // if there were results, seat is available
            if ( dataReader.Read() )
            {
               string seatNumber = dataReader.GetString( 0 );

               dataReader.Close();

               // update first available seat to be taken
               oleDbDataAdapter1.UpdateCommand.CommandText =
                  "Update Seats Set Taken = '1' WHERE Number = '"
                  + seatNumber + "'";
               oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();

               return true;

            } // end if
            dataReader.Close();
         } 
         catch ( OleDbException ) // if connection problem
         {
            return false;
         }
         finally 
         {
            oleDbConnection1.Close();
         }

         // no seat was reserved
         return false;

      } // end method Reserve

   } // end class Reservation

} // end namespace AirlineReservation


/*
 **************************************************************************
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/
