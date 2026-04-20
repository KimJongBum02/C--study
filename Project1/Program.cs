using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../sample.txt";
            if (!File.Exists(path))
            {
                // 데이터를 쓰기 위한 파일을 생성
                string createText = "Hello and Welcome\n";// 이 텍스트는 파일에 단 한 번만 추가
                File.WriteAllText(path, createText);
            }
            //파일을 삭제하지 않으면
            //아래 텍스트는 계속 추가되기 때문에 시간이 지날수록 파일의 길이가 늘어난다.            
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);

            // 파일을 읽기 위해 연다
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
