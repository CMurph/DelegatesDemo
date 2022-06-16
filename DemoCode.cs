using System;
using System.Linq;

namespace DemoBasic
{
    public class DemoCode
    {
        public delegate void TestDelegate();
        public delegate bool BoolDelegate(int i);

        public TestDelegate testDelegate;
        public BoolDelegate boolDelegate;
        public void Start()
        {
            testDelegate = () => { Console.WriteLine("I am an anom func"); };
            //testDelegate += MySecondFunction;
            testDelegate();

            boolDelegate = (p) => p > 5;
            Console.WriteLine(boolDelegate(9));
        }

        private void Myfunction()
        {
            Console.WriteLine("This is my function");
        }

        private void MySecondFunction()
        {
            Console.WriteLine("this is my second function");
        }

        private bool MyBoolFunction(int i)
        {
            return i > 5;
        }
    }
}
