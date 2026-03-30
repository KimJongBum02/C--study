using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0323_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("구입 금액 입력(최대 5000원까지) : ");
            int money = int.Parse(Console.ReadLine());
            
            if (5000 < money)
            {
                Console.WriteLine("허용된 범위 초과, 프로그램 종료");
                return;
            }

            int line = money / 1000;
            int[,] lotto = new int[line, 6];
            Random rand = new Random();
            int num;

            //for (int i = 0; i < line; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        num = rand.Next(1, 46);
            //        lotto[i, j] = num;
            //        Console.Write(lotto[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    bool dup;
                    do
                    {
                        dup = false;
                        num = rand.Next(1, 46);
                        for (int k = 0; k < j; k++)
                        {
                            if (lotto[i, k] == num)
                            {
                                dup = true;
                                break;
                            }
                        }
                    } while (dup);
                    lotto[i, j] = num;
                }
            }

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(lotto[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
