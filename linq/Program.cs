using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個用逗號區隔的整數數列：");
            var input = Console.ReadLine();
            var numbers = (input.Split(',').Reverse());
            Console.WriteLine(string.Join(",", numbers));
            Console.ReadLine();
        }
    }
}
