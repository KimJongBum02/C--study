using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project0330
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "../../sample.txt";
            //File.WriteAllText(path, "유한대학교\n");
            //File.WriteAllText(path, "컴퓨터소프트웨어전공\n");
            //File.AppendAllText(path, "김종범\n");
            //string result = File.ReadAllText(path);
            //Console.WriteLine(result);

            //string path = "../../log.txt";
            //FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            //string carInTime = "입차시간 => " + DateTime.Now.ToString() + "\n";
            //byte[] data = Encoding.UTF8.GetBytes(carInTime);
            //fs.Write(data, 0, data.Length);
            //fs.Close();
            //Console.WriteLine("차량이 입차했습니다.");

            //string path = "../../seek.txt";
            //FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            //byte[] alpha = Encoding.UTF8.GetBytes("ABCDEFGHIJ");
            //fs.Write(alpha, 0, alpha.Length);
            //fs.Close();

            //FileStream fsR = new FileStream(path, FileMode.Open, FileAccess.Read);
            //fsR.Seek(-3, SeekOrigin.End);
            //byte[] input = new byte[3];
            //fsR.Read(input, 0, input.Length);
            //string result = Encoding.UTF8.GetString(input);
            //Console.WriteLine(result);

            //string path = "../../data.txt";
            //StreamWriter sw = new StreamWriter(path);
            //sw.WriteLine("유한대학교");
            //sw.WriteLine("컴퓨터소프트웨어전공");
            //sw.WriteLine("김종범");
            //sw.WriteLine("온수역");
            //sw.Close();

            //StreamReader sr = new StreamReader(path);
            //string line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
            //sr.Close();

            //string path = "../../drowning.txt";
            //StreamWriter woodz = new StreamWriter(path);
            //woodz.WriteLine("ABC");
            //woodz.WriteLine("DEF");
            //woodz.WriteLine("GHI");
            //woodz.WriteLine("JKL");

            //woodz.Flush();

            //woodz.WriteLine("MNO");
            //woodz.WriteLine("PQR");
            //woodz.WriteLine("STU");
            //woodz.WriteLine("VWXYZ");
            //woodz.Close();

            //StreamReader sr = new StreamReader(path);
            //string line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
            //sr.Close();

            string path = "../../movie.txt";
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                Console.WriteLine("영화제목 => " + data[0]);
                Console.WriteLine("출연제목 => " + data[1]);
                Console.WriteLine("누적관객수 => " + data[2]);
                Console.WriteLine();
            }
            sr.Close();
        }
    }
}
