using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_7번___정수내림차순으로배치하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long answer = 0;
            char[] a = n.ToString().ToCharArray();
            Array.Sort(a);
            Array.Reverse(a);
            answer = Convert.ToInt32(new String(a));
            Console.WriteLine(answer);
        }
    }
}
