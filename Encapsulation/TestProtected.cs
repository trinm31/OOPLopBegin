using System;

namespace Encapsulation
{
    public class BaseClass
    {
        protected int _test = 4;

        public void Print()
        {
            Console.WriteLine(_test);
        }
    }
    
    public class TestProtected : BaseClass
    {
        public void PrintInTest()
        {
            Console.WriteLine(_test);
        }
    }
}