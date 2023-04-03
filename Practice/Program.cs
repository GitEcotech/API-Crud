using System;
using System.Collections.Generic;

namespace Practice
{
    public class Collection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            DemoArray a=new DemoArray();
            a.method();

            var countries =new HashSet<String>();
            countries.Add("India");
            countries.Add("Australia");
            countries.Add("Japan");  
            countries.Add("Canada");  
            countries.Add("India");

            Console.Write("Hash Set Output:-");
            foreach(var country in countries)
            {
                Console.Write(country+" ");
            }
            Console.WriteLine();
            DemoArrayList al=new DemoArrayList();

            ArrayListString alStr=new ArrayListString();

            DemoHashTable ht=new DemoHashTable();

            SortedListDemo sl=new SortedListDemo();
        }
    }
}
