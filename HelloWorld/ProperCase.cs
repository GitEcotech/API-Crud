using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;

namespace HelloWorld
{
    public class ProperCase
    {
        static ProperCase()
        {
            Console.WriteLine("Static Block of ProperCase");
        }
        public string Proper(string str){
            string[] arr=str.Split(' ');
            string finalStr="";
            foreach(var word in arr)
            {
                string firstLetter=word[0].ToString().ToUpper();
                string remaining= word.Substring(1).ToLower();
                finalStr=finalStr+firstLetter+remaining+" ";
            }
            return finalStr;
        }
    }
}