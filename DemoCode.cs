using System;
using System.Linq;

namespace DemoBasic
{
    public class DemoCode
    {
        public delegate void TestDelegate();
        public delegate bool TestBoolDelegate(int i);

        private TestDelegate testDelegate;
        private TestBoolDelegate testBoolDelegate;

        public void Start()
        {
            //testDelegate = MyTestFunction;
            //testDelegate();

            testBoolDelegate = MyBoolFunction;
            Console.WriteLine(testBoolDelegate(10));

        }

        private void MyTestFunction()
        {
            Console.WriteLine("This is my test Function");
        }

        private void MySecondTestFunction()
        {
            Console.WriteLine("This is my second function");
        }

        private bool MyBoolFunction(int i)
        {
            return i > 5;
        }
    }
}
