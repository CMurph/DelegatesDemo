using System;
using System.Linq;

namespace DemoBasic
{
    public class DemoCode
    {
        public delegate void TestDelegate();    // This delegate only takes zero parameters and returns void
        public delegate bool TestBoolDelegate(int i);   // This delegate take and int and returns bool

        private TestDelegate testDelegate;
        private TestBoolDelegate testBoolDelegate;

        public void Start()
        {
            testDelegate = MyTestFunction; 
            testDelegate();

            testBoolDelegate = MyBoolFunction; // Only the method name when assigning, no need to mention parameters
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
