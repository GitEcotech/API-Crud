using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1 = 10;
            int num2 =2;
            int sum = num1+num2;
            string firstName = "Bhagyashri";
            string lastName;
            Console.WriteLine(sum);
            float pi=(float)3.14;
            Console.WriteLine(pi);
            char ch='I';
            Console.WriteLine(ch);
            Console.WriteLine(firstName +" Jakkalkar");
            double db = (double)123.345;
            Console.WriteLine(db);
            bool boolean = true;
            Console.WriteLine(boolean);
            Console.WriteLine("enter last name");
            lastName=Console.ReadLine();
            Console.WriteLine(firstName+' '+lastName);

            InheritanceDemo p=new InheritanceDemo();
            p.Method1();
            p.Method2();
            Console.WriteLine("----------------------");
            InheritanceChild c=new InheritanceChild();
            c.Method1();
            c.Method2();
            Console.WriteLine("----------------------");
            InheritanceDemo cp=new InheritanceChild();
            cp.Method1();
            cp.Method2();
            Console.WriteLine("----------------------");
            OverloadingDemo over=new OverloadingDemo();
            Console.WriteLine(over.add(10,20)) ;
            Console.WriteLine(over.add(10,20,30)) ;
            Console.WriteLine(over.add("Bhagyashri","Jakkalkar")) ;
            
            ProperCase prop=new ProperCase();
            string str1=prop.Proper("hello world weLcoMe To thE paGe");
            Console.WriteLine(str1);

            AbstractConvert abs=new AbstractConvert();
            abs.sub(20,30);

            AbstractConvert abs1=new AbstractConvert();
            abs.sub(40,20);
            
        }
    }
}
