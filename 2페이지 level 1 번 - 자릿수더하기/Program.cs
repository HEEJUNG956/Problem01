using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_9번___자릿수더하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int answer = 0;
            while(i > 0)
            {
                answer += i % 10;
                i = i / 10;
            }
            Console.WriteLine(answer);
        }
    }
}
