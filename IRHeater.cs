using System;

namespace SingletonExample
{
    public class IRHeater
    {
        private IRHeater(){}

        private static IRHeater _instance;
        private static readonly object padlock = new object();
        public static IRHeater Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new IRHeater();
                    }
                    return _instance;
                }
            }
        }
    }
}
