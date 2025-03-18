using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 50, 85, 90, 30, 75, 100, 120, 95 };

           
            var queryA = from num in numbers
                         where num > 80
                         select num;
            var methodA = numbers.Where(num => num > 80);

            Console.WriteLine("Numbers > 80 (Query): " + string.Join(", ", queryA));
            Console.WriteLine("Numbers > 80 (Method): " + string.Join(", ", methodA));

         
            var queryB = from num in numbers
                         orderby num descending
                         select num;
            var methodB = numbers.OrderByDescending(num => num);

            Console.WriteLine("Descending Order (Query): " + string.Join(", ", queryB));
            Console.WriteLine("Descending Order (Method): " + string.Join(", ", methodB));

           
            var queryC = from num in numbers
                         select $"Have number {num}";
            var methodC = numbers.Select(num => $"Have number {num}");

            Console.WriteLine("Transformed Strings (Query): " + string.Join(" | ", queryC));
            Console.WriteLine("Transformed Strings (Method): " + string.Join(" | ", methodC));

            
            var queryD = from num in numbers
                         where num < 100 && num > 70
                         select num;
            int countD = queryD.Count(); 

            Console.WriteLine("Count of numbers between 70 and 100: " + countD);
        }
    }
}
