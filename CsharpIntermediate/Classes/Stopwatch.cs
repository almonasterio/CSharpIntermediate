using System;
using System.Threading;

namespace CSharpIntermediate.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch=new Stopwatch();
            for (var i=0; i<2;i++){

            stopwatch.Start();
            Thread.Sleep(10000);
            stopwatch.Stop();
            System.Console.WriteLine("Duration was " + stopwatch.GetInterval().ToString());
            System.Console.ReadLine();
            }


        }
    }
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private bool _hasStarted; 

        public void Start()
        {
            if (_hasStarted)
              throw new InvalidOperationException("The stopwatch has been started");

            _startTime=DateTime.Now;
            _hasStarted=true;

        }
        public void Stop() 
        {
            _endTime=DateTime.Now;
            _hasStarted=false;
        }
        public TimeSpan GetInterval(){
            return _endTime-_startTime;
        }

    }
}

