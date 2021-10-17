using System;

namespace SingletonExample
{
    public class IRHeater
    {
        private IRHeater(){}

        private static IRHeater _instance;

        public static IRHeater Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new IRHeater();
                }
                return _instance;
            }
        }
    }
}
