using System;
using System.Linq;

namespace DemoBasic
{
    public class DemoCode
    {
        // Bad practice
        public delegate void TestDelegate(); 
        public delegate bool BoolDelegate(int i);

        public TestDelegate testDelegate; 
        public BoolDelegate boolDelegate;

        private Action testAction;
        private Action<int, float> testIntFloatAction;

        private Func<bool> testBoolFunc;
        private Func<int, bool> testIntBoolFunc;

        public void Start()
        {
            testIntFloatAction = (int i, float f) => Console.WriteLine("This is intFloat");
            testIntFloatAction(7, 2.5f);

            testBoolFunc = () => false;
            Console.WriteLine(testBoolFunc());

            testIntBoolFunc = (i) => i > 5;
            Console.WriteLine(testIntBoolFunc(6));
        }
    }
}
