using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public interface AbstractDemo
    {
        public void add(int num1,int num2)
        {
            int sum = num1+num2;
            Console.WriteLine(sum);
        }
        void sub(int num1,int num2){}
    }
    public class AbstractConvert:AbstractDemo
    {
        public void sub(int num1,int num2)
        {
            Console.WriteLine("Sub="+(num1-num2));
        }
    }
    public class AbstractString:AbstractDemo
    {
        public void sub(int num1,int num2)
        {
            Console.WriteLine("Sub="+(num1-num2));
        }
    }
}