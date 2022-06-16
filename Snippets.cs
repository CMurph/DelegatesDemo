using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic
{
    internal class Snippets
    {
        //Two Delegates
/*   
public delegate void TestDelegate();
private TestDelegate myDelegate;
public void MyDelegateFunction()
    {
        Console.WriteLine("it works");
    }

public void MySecondFunction()
{
    Console.WriteLine("I also work");
}

public void Start()
{
    myDelegate = MyDelegateFunction; // No parameters needed just calling the functions name
    myDelegate = MySecondFunction;
    myDelegate();
}

*/


// Anoymous Declaration
/*
 
  myDelegate = delegate () { Console.WriteLine("Anonymous Delegate"); };
    myDelegate();
*/
}
}