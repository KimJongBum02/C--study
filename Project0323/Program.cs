using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0323
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학생 수 입력 : ");
            int input = int.Parse(Console.ReadLine());
            int[] score = new int[input];
            int sum = 0;

            for (int i = 0; i < score.Length; i++)
            {
                Console.Write("점수 " + (i + 1) + " 입력 : ");
                score[i] = int.Parse(Console.ReadLine());

                sum += score[i];
            }

            int max = 0, min = 1000000000;

            for (int i = 0; i < score.Length; i++)
            {
                if (max < score[i]) { max = score[i]; }
                if (score[i] < min) { min = score[i]; }
            }

            Console.WriteLine("점수 합계 : " + sum);
            Console.WriteLine("점수 평균 : " + sum / score.Length);
            Console.WriteLine("점수 최대값 : " + max);
            Console.WriteLine("점수 최소값 : " + min);
        }
    }
}
