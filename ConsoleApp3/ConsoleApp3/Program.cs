using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp3
{
    class Monsterdeth
    {
        static public int Monsterdethcount=0;
        

        public int deth()
        {
            ++Monsterdethcount;
            return Monsterdethcount;
        }
    }
    class Monster
    {
        public int AT = 10;
        public int HP = 100;

        public void ATT(Player _Player)
        {
            _Player.HP -= AT;
        }
    }
    class Player
    {
        public int AT = 10;
        public int HP = 100;

        public void ATT(Monster _Monster)
        {
            _Monster.HP -= AT;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            //HP 100 AT 10
            Monster NewMonster = new Monster();
            //HP 100 AT 10
            Player NewPlayer = new Player();
            NewMonster.ATT(NewPlayer);
            NewPlayer.ATT(NewMonster);
            //Console.WriteLine(NewPlayer.HP);
            //Console.WriteLine(NewMonster.HP);
            Monsterdeth M = new Monsterdeth();
            Monsterdeth M1 = new Monsterdeth();
            Monsterdeth M2 = new Monsterdeth();
            Monsterdeth.Monsterdethcount = 0;
            
            
            
            M.deth();
            M1.deth();
            M2.deth();
            
            

           Console.WriteLine(Monsterdeth.Monsterdethcount);
        }
    }
}