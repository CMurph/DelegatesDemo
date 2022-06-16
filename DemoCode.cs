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

        private Action testAction;
        private Action<int, float> testintFloat;

        private Func<bool> testboolFunc;
        private Func<int, bool> testIntFunc;

        public void Start()
        {
            testintFloat = (int i, float f) => Console.WriteLine("This is intFloat");
          //testintFloat(7, 2.5f);

            testboolFunc = () => false;
            Console.WriteLine(testboolFunc());

            testIntFunc = (i) => i > 5;
            Console.WriteLine(testIntFunc(6));
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
