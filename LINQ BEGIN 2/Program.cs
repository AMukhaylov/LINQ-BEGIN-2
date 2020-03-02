using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        // Вариант 2 Beginer
        static void Main(string[] args)
        {
            int D = 7;
            List<int> list1 = new List<int> { -10, 21, 46, 9, 10, -33, 77, 965, -80 };

            var result1 = list1.FirstOrDefault(x => (x > 0) && (x % 10 == D));

            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
