using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Project2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "../../log.txt";
            //FileStream fs = new FileStream(path, FileMode.Append,
            //    FileAccess.Write);
            //{
            //    string text = "로그 추가: " + DateTime.Now + "\n";
            //    byte[] data = Encoding.UTF8.GetBytes(text);
            //    fs.Write(data, 0, data.Length);
            //    Console.WriteLine("관객입장!");
            //}
            //Console.WriteLine("파일에 내용 추가 완료");

            //string path = "../../data.bin";
            //// 쓰기
            //FileStream fsW = new FileStream(path, FileMode.Create, FileAccess.Write);
            //BinaryWriter bw = new BinaryWriter(fsW);
            //bw.Write(100);       // 정수
            //bw.Write(3.14);      // 실수
            //bw.Write("Hello");   // 문자열
            //fsW.Close();//파일 닫기
            //// 읽기
            //FileStream fsR = new FileStream(path, FileMode.Open, FileAccess.Read);
            //BinaryReader br = new BinaryReader(fsR);
            //int num = br.ReadInt32();
            //double d = br.ReadDouble();
            //string str = br.ReadString();
            //fsR.Close();
            //Console.WriteLine($"{num}, {d}, {str}");
            //Console.WriteLine(num + ", " + d + ", " + str);

            //string path = "../../seek.txt";
            //// 1. 파일 생성 및 데이터 쓰기
            //FileStream fsW = new FileStream(path, FileMode.Create, FileAccess.Write);
            //byte[] data = Encoding.UTF8.GetBytes("ABCDEFGHIJ123456");
            //fsW.Write(data, 0, data.Length);
            //fsW.Close();

            //// 2. Seek 사용해서 특정 위치부터 읽기
            //FileStream fsR = new FileStream(path, FileMode.Open, FileAccess.Read);
            //// 5번째 위치로 이동 (0부터 시작)
            //fsR.Seek(5, SeekOrigin.Begin);
            //byte[] buffer = new byte[5];
            //fsR.Read(buffer, 0, buffer.Length);
            //fsR.Close();

            //string result = Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(result);

            //StreamWriter writer = new StreamWriter("../../data.txt");
            //writer.WriteLine("Hello");
            //writer.WriteLine("C# File IO");
            //writer.Close();

            //StreamReader reader = new StreamReader("../../data.txt");
            //string line;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
            //reader.Close();

            //StreamWriter sw = new StreamWriter("../../test.txt");
            //sw.Write("Hello");

            //// 아직 파일에 안 써졌을 수도 있음
            //sw.Flush();  // 강제로 저장
            //Console.WriteLine("중간 저장 완료");

            //sw.Write(" World");
            //sw.Write("What ");
            //sw.Write("is your name?");
            //sw.Close(); //파일 닫히면서 나머지도 저장됨

            //StreamReader reader = new StreamReader("../../student.txt");
            ////이번예제를 위해 메모장으로 student.txt를 미리 준비해둔다.
            //string line;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    string[] data = line.Split(',');
            //    string name = data[0];
            //    int score = int.Parse(data[1]);
            //    Console.WriteLine("이름 : " + name);
            //    Console.WriteLine("점수 : " + score);
            //}
            //reader.Close();


            //Person p1 = new Person { Name = "Hong Gil Dong", Age = 30 };//객체생성
            //string json = JsonSerializer.Serialize(p1);
            ////using System.Text.Json;, 객체직렬화
            //Console.WriteLine(json);

            //Person p2 = JsonSerializer.Deserialize<Person>(json);
            ////string 타입의 json을 Person 타입의 객체로 역직렬화

            //Console.WriteLine(p2.Name);//객체의 속성출력
        }
    }
}
