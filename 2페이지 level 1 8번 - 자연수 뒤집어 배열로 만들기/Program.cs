using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_8번___자연수_뒤집어_배열로_만들기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string temp = new string(n.ToString().ToCharArray().Reverse().ToArray());
            int[] answer = new int[temp.Length];

            for(int i = 0; i < temp.Length; i++)
            {
                answer[i] = int.Parse(temp[i].ToString());
                Console.Write(answer[i] + " ");
            }
        }
    }
}
