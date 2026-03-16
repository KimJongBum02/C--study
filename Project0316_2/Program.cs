using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project0316_2
{
    /// 플레이어 설정
    class Player
    {
        public int HP;
        public int Attack;
        public int Level;
        public int Exp;

        public Player()
        {
            HP = 100;
            Attack = 10;
            Level = 1;
            Exp = 0;
        }

        public void AttackMonster(Monster monster)
        {
            monster.HP -= this.Attack;

            Console.WriteLine("플레이어가 몬스터 공격");
            Console.WriteLine("몬스터의 현재 HP : " + monster.HP);
        }

        public void GainExp(int amount)
        {
            Exp += amount;
            if (Exp >= 10)
            {
                Level++;
                Exp = 0;
                HP = 100;
                Attack += 5;

                Console.WriteLine();
                Console.WriteLine("레벨 업");
                Console.WriteLine("레벨이 " + Level + "로 상승");
            }
        }

        public void showState()
        {
            Console.WriteLine("플레이어의 HP : " + this.HP);
            Console.WriteLine("플레이어의 Attack : " + this.Attack);
            Console.WriteLine("플레이어의 Level : " + this.Level);
            Console.WriteLine("플레이어의 Exp : " + this.Exp);
        }
    };

    /// 몬스터 설정
    class Monster
    {
        public int HP;
        public int Attack;
        public Monster()
        {
            HP = 50;
            Attack = 5;
        }

        public void AttackPlayer(Player player)
        {
            player.HP -= this.Attack;

            Console.WriteLine("몬스터가 플레이어 공격");
            Console.WriteLine("플레이어의 현재 HP : " + player.HP);
        }

        public void showState()
        {
            Console.WriteLine("몬스터 HP : " + this.HP);
            Console.WriteLine("몬스터 Attack : " + this.Attack);
        }
    };
    internal class Program 
    {
        static void Main(string[] args)
        {
            Player superMan = new Player();
            Monster zombie = new Monster();
            Console.WriteLine("---------- 전투 개시 ----------");
            
            while(superMan.HP > 0 && zombie.HP > 0)
            {
                Console.WriteLine("1. 공격");
                Console.WriteLine("2. 도망");
                Console.Write("선택 : ");

                int input = 0;
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    superMan.AttackMonster(zombie);

                    if (zombie.HP <= 0)
                    {
                        Console.WriteLine("플레이어 승리");
                        superMan.GainExp(10);
                        break;
                    }

                    zombie.AttackPlayer(superMan);
                }
                else if (input == 2)
                {
                    Console.WriteLine("도망간다");
                    break;
                }
            }

            Console.WriteLine("---------- 전투 종료 ----------");

            /// 결과창 클래스 호출
            superMan.showState();
            Console.WriteLine();
            zombie.showState();

            //Console.WriteLine("플레이어의 HP : " + superMan.HP);
            //Console.WriteLine("플레이어의 Attack : " + superMan.Attack);
            //Console.WriteLine("플레이어의 Level : " + superMan.Level);
            //Console.WriteLine("플레이어의 Exp : " + superMan.Exp);
            //Console.WriteLine();

            //Console.WriteLine("몬스터 HP : " + zombie.HP);
            //Console.WriteLine("몬스터 Attack : " + zombie.Attack);
        }
    }
}
