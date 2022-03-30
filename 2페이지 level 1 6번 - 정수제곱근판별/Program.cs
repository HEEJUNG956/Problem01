using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_6번___정수제곱근판별
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long answer = 0;

            var a = Math.Sqrt(n);

            if(a % 1.0 != 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                answer = (long)a;
                answer += 1;
                answer *= answer;
                Console.WriteLine(answer);
            }
        }
    }
}
