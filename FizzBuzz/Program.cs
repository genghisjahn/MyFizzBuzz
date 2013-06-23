using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            RunLoop(1,100);
            Console.ReadLine();
        }
        static void RunLoop(int low, int high)
        {
            List<FizzBuzzItem> fbitems = new List<FizzBuzzItem>();
            fbitems.Add(new FizzBuzzItem(new List<int> { 3 }, "fizz", 3));
            fbitems.Add(new FizzBuzzItem(new List<int> { 5 }, "buzz", 2));
            fbitems.Add(new FizzBuzzItem(new List<int> { 3,5 }, "fizzbuzz", 1));

            FizzBuzzProcessor fbproc = new FizzBuzzProcessor(fbitems);
            

            for (int i = low; i <= high; i++)
            {
                Console.WriteLine("No. {0}: {1}",i.ToString(), fbproc.ItemMessage(i));
            }
        }
    }
}
