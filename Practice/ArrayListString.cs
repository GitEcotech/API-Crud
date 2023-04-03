using System;
using System.Collections;

namespace Practice
{
    public class ArrayListString
    {
        public ArrayListString()
        {
            var al=new ArrayList();
            al.Add("abc");
            al.Add("def");
            al.Add("ghi");
            al.Add("jkl");
            al.Add(30);
            al.Add(50);

            Console.Write("String Array List Output:-");
            foreach(var item in al)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine("String ArrayList Capacity: {0} ", al.Capacity);
            Console.WriteLine("String ArrayList Count: {0}", al.Count);

            /*al.Sort();
            Console.Write("Sorted ArrayList:-");
            foreach(var item in al)
            {
                Console.Write(item+" ");
            }*/
            //Console.WriteLine();
        }
    }
}