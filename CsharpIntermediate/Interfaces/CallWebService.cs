namespace CsharpIntermediate.Interfaces
{
    public class CallWebService : ITask
    {
        public void Execute(){
            System.Console.WriteLine("Calling Web Service");
        }
    }
}