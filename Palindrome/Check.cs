namespace Palindrome
{
    public class Check
    {
        public Check(dynamic str)
        {  
            dynamic[] arr=str.Split();
            Console.Write("Given String=");
            foreach(var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            dynamic[] revArr=new dynamic[str.Length];
            int i=0;
            for(int j=str.Length-1;j>=0;j--)
            {
                revArr[i++]=str[j];
            }
            Console.Write("Rev str=");
            foreach(var item in revArr)
            {
                Console.Write(item);
            }
            Console.WriteLine(arr.SequenceEqual(revArr));
        }
    }
}