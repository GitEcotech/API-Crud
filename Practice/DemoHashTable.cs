
using System.Collections;


namespace Practice
{
    public class DemoHashTable
    {
        public DemoHashTable()
        {
            var hash=new Hashtable();
            hash.Add(1,"tanvi");
            hash.Add(2,"shweta");
            hash.Add(3,"tanvi");
            hash.Add(4,"tanvi");
            hash.Add(5,"pooja");
            hash.Add(6,"Pooja");
            hash.Add(7,"shifa");
            if(hash.Contains("Bhagyashri")){
                Console.WriteLine("Students data exits");
            }else{
                hash.Add(8,"Bhagyashri");
            }

            Console.Write("Hash Table output:-");
            ICollection key=hash.Keys;
            foreach(var item in key)
            {
                Console.Write(item + ":"+hash[item]+", ");
            }
            Console.WriteLine();
        }
    }
}
