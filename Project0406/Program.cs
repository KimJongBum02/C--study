using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace Project0406
{
    internal class Program
    {
        /// 직렬화 및 역직렬화 실습을 위한 클래스 생성
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            //public Person(string n, int a)
            //{
            //    Name = n;
            //    Age = a;
            //}
        }
        static void Main(string[] args)
        {
            /// 직렬화
            Person p1 = new Person { Name = "김종범", Age = 25 };
            string people = JsonSerializer.Serialize(p1);
            Console.WriteLine(people);
            StreamWriter sw = new StreamWriter("../../people.json");
            sw.WriteLine(people);
            sw.Close();

            /// 역직렬화
            StreamReader sr = new StreamReader("../../people.json");
            string line = sr.ReadLine();
            Person p2 = JsonSerializer.Deserialize<Person>(line);

            /// JSON 형태를 객체로 변환
            Console.WriteLine("이름 : " + p2.Name);
            Console.WriteLine("나이 : " + p2.Age);
            sr.Close();
        }
    }
}
