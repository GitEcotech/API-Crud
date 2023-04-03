using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class InheritanceDemo
    {
        public void Method1(){
            Console.WriteLine("Method 1 from parent class");
        }
        public virtual void Method2(){
            Console.WriteLine("Method 2 from parent class");
        }
    }

    public class InheritanceChild:InheritanceDemo
    {
        public new void Method1(){
            Console.WriteLine("Metod 1 from child class");
        }
        public override void Method2()
        {
            Console.WriteLine("Method 2 from child class");
        }
    }
}