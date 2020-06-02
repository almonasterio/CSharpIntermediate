using System;

namespace CSharpIntermediate
{

    public class Stopwatch
    {
        public TimeSpan Duration { get; private set; }
        private DateTime _startTime;
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
            Duration=DateTime.Now -_startTime;
            _hasStarted=false;
        }

    }
}

