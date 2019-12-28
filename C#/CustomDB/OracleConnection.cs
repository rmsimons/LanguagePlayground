namespace CustomDB
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base (connectionString)
        {
            // Intentionally left blank
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Close Oracle connection");
        }

        public override void OpenConnection()
        {
            System.Console.WriteLine("Open Oracle connection");
        }
    }
}
