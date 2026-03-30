using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0323_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] seats = new int[3][];
            seats[0] = new int[10];
            seats[1] = new int[8];
            seats[2] = new int[12];

            while (true)
            {           
                Console.Write("상영관 선택(1 ~ 3, 0 누르면 종료) : ");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("1관 자리 보기");
                    for (int i = 0; i < seats[0].Length; i++)
                    {
                        Console.Write("[ ]\t");
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("2관 자리 보기");
                    for (int i = 0; i < seats[1].Length; i++)
                    {
                        Console.Write("[ ]\t");
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("3관 자리 보기");
                    for (int i = 0; i < seats[2].Length; i++)
                    {
                        Console.Write("[ ]\t");
                    }
                }
                else
                {
                    Console.WriteLine("허용된 범위 초과, 프로그램 종료");
                    return;
                }

                if (input == 0) { return; }

                Console.WriteLine("0 입력, 프로그램 종료");
            }
        }
    }
}
