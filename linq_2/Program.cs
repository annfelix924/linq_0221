using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個用逗號區隔的整數數列：");
            var input = Console.ReadLine();
            var numbers = input.Split(',').Select(int.Parse).OrderBy(n=>n);
            var oddNumbers = numbers.Where(n => n % 2 == 1);
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("奇數: " + string.Join(",", oddNumbers));
            Console.WriteLine("偶數: " + string.Join(",", evenNumbers));
            Console.ReadLine();
         }
     }

}

