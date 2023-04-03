using System;
using System.Collections;

namespace Practice
{
    public class DemoArrayList
    {
        ArrayList al = new ArrayList();
        public DemoArrayList()
        {
            al.Add(45);
            al.Add(20);
            al.Add(40);
            al.Add(80);
            al.Add(50);
            al.Add(-20);
            Console.Write("Array List Output:-");
            foreach(var item in al)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList Capacity: {0} ", al.Capacity);
            Console.WriteLine("ArrayList Count: {0}", al.Count);

            al.Sort();
            Console.Write("Sorted ArrayList:-");
            foreach(int item in al)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}