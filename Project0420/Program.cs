using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yuhan.ComSoft.CSharp;

namespace Project0420
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// IWeapon을 이용한 공격 방식 로직
            //Character johnWick = new Character();
            //Sword mugi_1 = new Sword("롱소드");
            //johnWick.weapon = mugi_1;
            //johnWick.AttackGo(1);
            //johnWick.AttackGo(2);
            //johnWick.AttackGo(2);

            //Gun mugi_2 = new Gun("권총");
            //johnWick.AttackGo(1);
            //johnWick.AttackGo(2);
            //johnWick.AttackGo(2);

            /// IPayment를 이용한 결제 방식 로직
            //Console.Write("결제 방식을 선택하세요(exit 입력 시 종료 : ");
            //string input = Console.ReadLine();
            //IPayment pay;
            //switch (input)
            //{
            //    case "1":
            //        pay = new CardPayment();
            //        Console.WriteLine("카드 결제 방식 선택");
            //        break;
            //    case "2":
            //        pay = new CashPayment();
            //        Console.WriteLine("현금 결제 방식 선택");
            //        break;
            //    case "3":
            //        pay = new KakaoPayment();
            //        Console.WriteLine("카카오 페이 선택");
            //        break;
            //    case "exit":
            //        Console.WriteLine("프로그램 종료");
            //        return;
            //    default:
            //        Console.WriteLine("없는 결제 방식입니다.");
            //        return;
            //}
            //pay.Pay(5000);

            /// IPower, IInternet을 이용한 tv 동작 로직
            //SmartTV tv = new SmartTV("삼성", 75);
            //tv.On();
            //Console.WriteLine("우리 집 TV 크기 : " + tv.Size + "인치");
            //tv.Connect();
            //tv.Off();

            //RiceCooker bobsot = new RiceCooker("쿠첸", 5);
            //bobsot.On();
            //if (bobsot.Size >= 10)
            //{
            //    Console.WriteLine("삼계탕 요리 가능");
            //}
            //else
            //{
            //    Console.WriteLine("삼계탕 요리 불가능");
            //}
            //Console.WriteLine("우리 집 밥솥은 " + bobsot.Size + "인용 입니다.");
            //bobsot.Connect();
            //bobsot.Off();


            /// IPower, IInternet을 이용한 전자레인지 동작 로직
            Microwave mw = new Microwave("삼성", "계란찜");
            mw.On();
            mw.Connect();
            mw.Off();
            
        }
    }
}
