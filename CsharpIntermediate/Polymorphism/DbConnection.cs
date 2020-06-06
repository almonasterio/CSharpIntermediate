using System;

namespace CsharpIntermediate.Polymorphism
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeOut;
        protected DbConnection(string connectionString)
        {
                if (String.IsNullOrWhiteSpace(connectionString))
                    throw new ArgumentException("The connection string is invalid");
            _connectionString=connectionString;
        }  
        public abstract void Open();
        
        public abstract void Close();
        
    }
}