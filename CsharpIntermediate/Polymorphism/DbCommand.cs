using System;

namespace CsharpIntermediate.Polymorphism
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if(dbConnection==null)
              throw new ArgumentException("Null DbConnection");
            if (String.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("Null instruction");
            _dbConnection=dbConnection;
            _instruction=instruction;
        }
        public void Execute()
        {
            _dbConnection.Open();
            System.Console.WriteLine("Instruction running: " + _instruction);
            _dbConnection.Close();

        }
    }
}