using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected string name="NONE";
    protected int AT=10;
    protected int HP = 50;
    protected int MAXHP = 100;

    public bool IsDeath( )
    {
        return HP<=0;
    }

    public void StatusRender()
    {
        Console.WriteLine(name+"의 능력치------------------------");
        Console.WriteLine("공격력 : "+AT);
        Console.WriteLine("체력 : "+HP+"/"+MAXHP);
        Console.WriteLine("------------------------");
    }

    public void Damage(FightUnit otherunit)
    {
        Console.Write(name);
        Console.Write("가");
        Console.Write(otherunit.AT);
        Console.WriteLine("의 데미지를 입었습니다.");
        Console.ReadKey();
        HP -= otherunit.AT;
    }

}

class Monster : FightUnit
{
    public Monster(string name)
    {
        this.name = name;
    }
}

class Player : FightUnit
{
  
    public void Heal()
    {
        if (HP >= MAXHP)
        {
            Console.WriteLine(" ");
            Console.WriteLine("체력이 모두 회복되어있어서 회복할 필요가 없습니다.");
            Console.ReadKey();
        }
        else
        {
            this.HP = MAXHP;
            printHP();
        }
        return;
    }
    void printHP()
    {
        Console.WriteLine("");
        Console.Write("현재 플레이어의 HP는");
        Console.Write(HP);
        Console.WriteLine("입니다.");
        
    }    
    public Player()
    {
        name = "플레이어";
    }
}
enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT
}

namespace TextRpg001
{
    class Test
    {
        
    }
    class Program
    {
      static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("1.마을");
            Console.WriteLine("2.배틀");
            Console.WriteLine("어디로 가시겠습니까?");

            ConsoleKeyInfo CKI = Console.ReadKey();

            Console.WriteLine("");

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                    
                case ConsoleKey.D2:
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;



            }
        }
        static STARTSELECT Town(Player _player)
        {
            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                Console.WriteLine("");
                Console.WriteLine("마을에서 무슨일을 하시겠습니까?");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화핟나.");
                Console.WriteLine("3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _player.Heal();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return STARTSELECT.NONESELECT;
                }
                Console.ReadKey();
            }
        }
        static STARTSELECT Battle(Player P)
        {
            //Console.Clear();
            //Console.WriteLine("아직 개장하지 않았습니다.");
            //Console.ReadKey();

            Monster M = new Monster("오크");

            while (false ==P.IsDeath() && false== M.IsDeath())
            {
                Console.Clear();
                P.StatusRender();
                M.StatusRender();   
                
                M.Damage(P);

                if (false == M.IsDeath())
                {
                    P.Damage(M);
                }            
            }

            if(true == M.IsDeath())
            {
                Console.WriteLine("플레이어의 승리입니다.");
            }
            else
                Console.WriteLine("몬스터의 승리입니다.");

            Console.WriteLine("싸움이 결판 났습니다.");
            Console.ReadKey();
            return STARTSELECT.SELECTTOWN;
        }
        static void Main(string[] args)  
        {
            
            Player P = new Player();

            STARTSELECT SelectCheck = STARTSELECT.NONESELECT;

            while (true)
            {
                if(SelectCheck==STARTSELECT.NONESELECT)
                SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.NONESELECT:
                        SelectCheck = StartSelect();
                        break;
                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = Town(P);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = Battle(P);
                        break;
                }
            }
        }
    }
}
