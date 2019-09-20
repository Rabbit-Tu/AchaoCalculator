using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcilator
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("请输入要出题的个数：");
                int n = Convert.ToInt32(Console.ReadLine());
                opreation.PrintCalculator(n);
                Console.ReadKey();
        }
    }
}
