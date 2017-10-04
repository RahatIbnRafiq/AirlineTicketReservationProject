using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace OracleConnection
{
    class MainClass
    {
       
        public static void Main()
        {
            OracleConnect oc = new OracleConnect("localhost", "orcl", "rifat", "0105037");
            DataTable table=oc.searchDB("select * from lib_book");
            foreach (DataRow dr in table.Rows)
            {
                Console.Write("BookId:" + dr["BookId"]);
                Console.WriteLine(" Title:" + dr["Title"]);
            }
            /*
            DataSet set = oc.searchDBSet("select * from lib_book");
            foreach (DataRow dr in set.Tables[0].Rows)
            {
                Console.Write("BookId:" + dr["BookId"]);
                Console.WriteLine(" Title:" + dr["Title"]);
            } 
            */
            Console.ReadLine();
        }

    }
}
