using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Diagnostics.PerformanceData;

namespace Project3
{
    class Student
    {
        public string Name { get; set; }//속성
        public int Score { get; set; }//속성
    }        
    internal class Program
    {        
        static Student student = new Student();//전역객체로 사용
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("1. 학생정보입력(텍스트문서)");
                Console.WriteLine("2. 학생정보불러오기(텍스트문서)");
                Console.WriteLine("3. 전체학생 평균점수 보기(텍스트문서)");
                Console.WriteLine("4. 학생정보입력(객체)");
                Console.WriteLine("5. 학생정보불러오기(객체)");
                Console.WriteLine("6. 전체학생 평균점수 보기(객체)");
                Console.WriteLine("7. 종료(X)");
                Console.WriteLine("========================================");

                Console.WriteLine();
                Console.Write("메뉴 선택 : ");
                string menu = Console.ReadLine();
                Console.WriteLine();

                while (true)
                {
                    if (menu == "1")
                    {
                        //1. 학생정보입력(텍스트문서)
                        //y 선택?
                        //n 선택
                        //잘못된 값?
                    }
                    else if(menu == "2")
                    {
                        //2. 학생정보불러오기(텍스트문서)
                    }
                    else if (menu == "3")
                    {
                        //3.전체학생 평균점수 보기(텍스트문서)
                    }
                    else if (menu == "4")
                    {
                        //4. 학생정보입력(객체)
                        AddStudent();
                        SaveToJson();
                        Console.Write("계속 ?(Y/N) : ");
                        string input = Console.ReadLine();
                        if (input == "y" || input == "Y")
                        {
                            
                        }
                        else if (input == "n" || input == "N")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 접근\n");
                            break;
                        }
                    }
                    else if(menu == "5")
                    {
                        //5. 학생정보불러오기(객체)
                        LoadFromJson();
                        break;
                    }
                    else if (menu == "6")
                    {
                        //6. 전체학생 평균점수 보기(객체)
                        CalculateAverage(menu);
                        break;
                    }
                    else if(menu == "7")
                    {
                        //7. 종료(X)
                        Console.WriteLine("프로그램 종료");
                        return;
                    }
                }//안쪽 while문 끝
                Console.WriteLine();
            }//바깥쪽 while문 끝            
        }//main 끝
        //학생 추가 및 정보입력
        static void AddStudent()
        {
            Console.Write("이름 입력 : ");
            student.Name = Console.ReadLine();
            Console.Write("영어 점수 입력 : ");
            student.Score = int.Parse(Console.ReadLine());
        }
        //TXT 파일 저장하기
        static void SaveToText()
        {
            
        }
        //TXT 파일 불러오기
        static void LoadFromText()
        {
            
        }
        //평균계산
        static void CalculateAverage(string menu)
        {
            if (menu == "3")
            {
                //텍스트문서 평균구하기
            }
            else if(menu == "6")
            {
                //역직렬화된 객체의 평균 구하기
                StreamReader sr = new StreamReader("../../eng.json");
                int sum = 0, count = 0;
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] obj = line.Split('\n');
                    Student s = JsonSerializer.Deserialize<Student>(obj[0]);
                    sum += s.Score;
                    count++;
                }
                Console.WriteLine("영어 점수 합계 : " + sum);
                Console.WriteLine("영어 점수 평균 : " + (sum / count));

            }
        }
        //JSON 저장(직렬화)
        static void SaveToJson()
        {
            StreamWriter sw = new StreamWriter("../../eng.json", true);
            /// append 모드(추가)
            string english = JsonSerializer.Serialize(student);
            sw.WriteLine(english);
            sw.Close();
        }
        //JSON불러오기(역직렬화)
        static void LoadFromJson()
        {
            StreamReader sr = new StreamReader("../../eng.json", true);
            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] obj = line.Split('\n');
                Student s = JsonSerializer.Deserialize<Student>(obj[0]);
                Console.WriteLine(s.Name + " 학생의 영어 점수는 " + s.Score + "점");
            }
            sr.Close();
        }
    }
}
