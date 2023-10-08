using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinqExample
    {
        int[] db = new int[5] { 0, 1, 2, 3, 4};

        public void QueryFunction()
        {
            var numQuery =
                from num in db
                where (num % 2) == 0
                orderby num descending
                select num;
            List<int> ToTheList = numQuery.ToList();
            foreach (int num in ToTheList)
            {
                Console.WriteLine(num);
            }

        }
    }
}
