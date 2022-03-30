using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_10번___이상한문자만들기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int num = 0;
            string answer = "";

            for(int i = 0; i < s.Length; i++)
            {
                answer += num % 2 == 0 ? s[i].ToString().ToUpper() : s[i].ToString().ToLower();
                num = s[i] == ' ' ? 0 : num + 1;
            }
            Console.WriteLine(answer);
        }
    }
}
