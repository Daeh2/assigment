using System;

namespace ConsoleApp2
{
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
           
        }
    }
}
