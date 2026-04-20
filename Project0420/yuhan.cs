using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Yuhan.ComSoft.CSharp
{
    //interface IWeapon
    //{
    //    void Attack(string w);
    //}

    //class Sword : IWeapon
    //{
    //    public string Name { get; set; }
    //    public Sword(string sName)
    //    {
    //        Name = sName;
    //    }

    //    public void Attack(string w)
    //    {
    //        Console.WriteLine(Name + "로 " + w + " 공격");
    //    }
    //}

    //class Gun : IWeapon
    //{
    //    public string Name { get; set; }
    //    public Gun(string gName)
    //    {
    //        Name = gName;
    //    }

    //    public void Attack(string w)
    //    {
    //        Console.WriteLine(Name + "으로 공격");
    //    }
    //}

    //class Character
    //{
    //    public IWeapon weapon;
    //    public void AttackGo(int hand)
    //    {
    //        if (hand == 1) { weapon.Attack("양손"); }
    //        else if (hand == 2) { weapon.Attack("한손"); }
    //    }
    //}

    //interface IPayment
    //{
    //    void Pay(int amount);
    //}

    //class CardPayment : IPayment
    //{
    //    public void Pay(int amount)
    //    {
    //        Console.WriteLine("카드 : " + amount + "원 결제");
    //    }
    //}

    //class CashPayment : IPayment
    //{
    //    public void Pay(int amount)
    //    {
    //        Console.WriteLine("현금 : " + amount + "원 결제");
    //    }
    //}

    //class KakaoPayment : IPayment
    //{
    //    public void Pay(int amount)
    //    {
    //        Console.WriteLine("카카오 페이 : " + amount + "원 결제");
    //    }
    //}

    interface IPower
    {
        void On();
        void Off();
    }

    interface  IInternet
    {
        void Connect();
    }

    class SmartTV : IPower, IInternet
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public SmartTV(string brand, int inch)
        {
            Name = brand;
            Size = inch;
        }

        public void On()
        {
            Console.WriteLine(Name + "TV 전원 ON");
        }

        public void Off()
        {
            Console.WriteLine(Name + "TV 전원 OFF");
        }

        public void Connect()
        {
            Console.WriteLine(Name + "TV 인터넷 연결 성공");
        }
    }

    class RiceCooker : IPower, IInternet
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public RiceCooker(string brand, int total)
        {
            Name = brand;
            Size = total;
        }
        public void On()
        {
            Console.WriteLine(Name + "(이)가 맛있는 요리를 시작했습니다.");
        }

        public void Off()
        {
            Console.WriteLine(Name + "(이)가 맛있는 요리를 완성하였습니다.\n보온모드로 전환됩니다.");
        }

        public void Connect()
        {
            Console.WriteLine("WIFI로 인터넷 연결");
        }
    }

    class Microwave : IPower, IInternet
    {
        public string Name { get; set; }
        public string Food { get; set; }

        public Microwave(string brand, string cook)
        {
            Name = brand;
            Food = cook;
        }

        public void On()
        {
            Console.WriteLine($"{Name} 전자레인지가 {Food}을(를) 만듭니다.");
        }
        
        public void Off()
        {
            Console.WriteLine($"{Name} 전자레인지가 {Food}을(를) 완성했습니다.\n전원이 꺼집니다.");
        }

        public void Connect()
        {
            Console.WriteLine($"{Name} 전자레인지가 WIFI에 연결되었습니다.");
        }
    }
    internal class yuhan
    {
    }
}
