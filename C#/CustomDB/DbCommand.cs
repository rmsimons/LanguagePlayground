using System;

namespace CustomDB
{
    class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("Must pass a valid DB connection");
            }

            if (string.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException("Must pass a valid instruction");
            }

            _connection = connection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine(_instruction);
            _connection.CloseConnection();
        }
    }
}
