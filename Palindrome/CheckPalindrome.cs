using System.Collections;

namespace Palindrome
{
    public class CheckPalindrome
    {
        public CheckPalindrome(dynamic argu)
        {
            List<dynamic> arr=new List<dynamic>();
            arr.Add(argu);
            Console.Write("Given String=");
            foreach(dynamic i in arr)
            {
                Console.Write(i);
            }

            List<dynamic> l=new List<dynamic>();
            for(var i=argu.Length-1;i>=0;i--)
            {
                l.Add(argu[i]);
            }
            Console.WriteLine();
            Console.Write("Reverse=");
            foreach(dynamic i in l)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            bool result = arr.SequenceEqual(l)?false:true;
            Console.WriteLine(result);

            
        }
    }
}