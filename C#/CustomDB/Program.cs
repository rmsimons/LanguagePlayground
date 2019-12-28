using System;

namespace CustomDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectSqlCommand = new DbCommand(new SqlConnection("connecting with Sql..."), "SELECT * FROM DB");
            var selectOracleCommand = new DbCommand(new OracleConnection("connecting with Oracle..."), "SELECT * FROM DB");

            selectSqlCommand.Execute();
            Console.WriteLine();
            selectOracleCommand.Execute();
        }
    }
}
