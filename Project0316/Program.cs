using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 100;
            int playerAttack = 10;

            Console.WriteLine("플레이어 등장");
            Console.WriteLine("HP : " + playerHP);
            Console.WriteLine("Attack : " + playerAttack);
            Console.WriteLine();

            int monsterHP = 100;
            int monsterAttack = 5;

            Console.WriteLine("몬스터 등장");
            Console.WriteLine("HP : " + monsterHP);
            Console.WriteLine("Attack : " + monsterAttack);
            Console.WriteLine();

            Console.WriteLine("---------- 전투 시작 ----------");

            while (playerHP > 0 && monsterHP > 0)
            {
                playerHP -= monsterAttack;
                Console.WriteLine("몬스터의 공격");
                Console.WriteLine("플레이어 HP : " + playerHP);

                monsterHP -= playerAttack;
                Console.WriteLine("플레이어의 공격");
                Console.WriteLine("몬스터 HP : " + monsterHP);
            }

            Console.WriteLine("---------- 전투 종료 ----------");

            int exp = 0;
            int level = 1;
            
            if (playerHP <= 0) 
            {
                Console.WriteLine("몬스터 승리"); 
            }
            else if (monsterHP <= 0) 
            {
                Console.WriteLine("플레이어 승리");
                exp += 10;
            }

            if (exp >= 10)
            {
                level++;
                Console.WriteLine("레벨이 " + level + "로 상승");
            }
        }
    }
}
