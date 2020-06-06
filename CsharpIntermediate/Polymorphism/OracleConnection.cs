namespace CsharpIntermediate.Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void Open()
        {
            System.Console.WriteLine("Connection is open");
        }

        public override void Close()
        {
            System.Console.WriteLine("Connection is closed");
        }
        
    }
}