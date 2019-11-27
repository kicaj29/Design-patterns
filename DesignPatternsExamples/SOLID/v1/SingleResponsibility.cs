using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.v1
{
    public class SingleResponsibility
    {
        //------wrong approach------
        class DataAccess
        {
            public static void InsertData()
            {
                // here we insert some data into DB...

                // here we do logging
                Console.WriteLine("Data inserted into database successfully");
                Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
            }
        }
        /* So tomorrow if you want add a new logging like event viewer or File I/O then we need to go and change the “DataAccess”class,
         * which is not right.
         * It’s like if “JOHN” has a problem why do I need to check “BOB”.
         */

        //------correct approach------

        // Data access class is only responsible for data base related operations 
        class DataAccessOK
        {
            public static void InsertData()
            {
                // here we insert some data into DB...

                // here we do logging
                Logger.WriteLog();
            }
        }
        // Logger class is only responsible for logging related operations 
        class Logger
        {
            public static void WriteLog()
            {
                Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
            }
        }

    }
}
