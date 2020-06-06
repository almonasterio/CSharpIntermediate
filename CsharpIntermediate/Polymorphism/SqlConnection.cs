namespace CsharpIntermediate.Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }
        public override void Open()
        {
            System.Console.WriteLine("SQL Connection is open");
        }

        public override void Close()
        {
            System.Console.WriteLine("SQL Connection is closed");
        }
        
    }
}