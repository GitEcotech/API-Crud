using System.Collections;
namespace Practice
{
    public class SortedListDemo
    {
        public SortedListDemo()
        {
            var sl=new SortedList();
            sl.Add(01,"abc");
            sl.Add(02,"def");
            sl.Add(03,"ghi");
            sl.Add(04,"jkl");
            sl.Add(05,"mno");
            sl.Add(06,"pqr");
            sl.Add(07,"stu");

            ICollection keys = sl.Keys;
            Console.Write("Sorted list Items:-");
            foreach(var key in keys)
            {
                Console.Write(" "+key+ ":"+sl[key]);
            }
            Console.WriteLine();
        }
    }
}