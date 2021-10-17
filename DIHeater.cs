using System;

namespace SingletonExample
{
    public class DIHeater
    {
        private DIHeater(){}

        private static DIHeater _diheater;

        public static DIHeater GetInstance()
        {
            if(_diheater == null)
            {
                _diheater = new DIHeater();
            }
            return _diheater;
        }
    }
}
