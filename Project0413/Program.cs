using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0413
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("숫자1 입력 : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("숫자2 입력 : ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.Write(num1 + " / " + num2 + " = " + result);

                throw new IndexOutOfRangeException("배열 인덱스 에러");
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("분자나 분모는 반드시 정수여야 함");
            }
            catch(DivideByZeroException dze)
            {
                Console.WriteLine(dze.Message);
                Console.WriteLine("0으로 나눌 수 없음");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("GG !");
            }
        }
    }
}
