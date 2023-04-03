using System;

namespace Practice
{
public class DemoArray
{
     string[]? strArr;
    public void method()
    {
        Console.WriteLine("Array class");
        int[] arr={1,2,3,4,5};
       strArr=new string[]{"abc","def","ghi"};
       Console.Write("Array Output:-");
       foreach(string word in strArr){
        Console.Write(word+" ");
       }
       Console.WriteLine();
    }
}
}