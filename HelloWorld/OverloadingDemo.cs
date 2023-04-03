using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class OverloadingDemo
    {
        public int add(int num1,int num2){
            return num1+num2;
        }
        public int add(int num1,int num2,int num3){
            return num1+num2+num3;
        }
        public string add(string str1,string str2){
            return str1+" "+str2;
        }
    }
}