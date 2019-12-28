using System;

namespace CustomDB
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            // Intentionally left blank
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Sql connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close Sql connection");
        }
    }
}
