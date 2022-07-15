using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int HP = 100;
    //정적 멤버변수만을 정적 멤버 함수에서 사용할 수 있다.
    private static int StTest =100;
    public void Heal(int _Heal)
    {
        this.HP += _Heal;
    }

    public static void Demage(Player _this, int _Dmg)
    {
        _this.HP-=_Dmg;
    }
    public static void PVP(Player _left,Player _right)
    {
        //HP = 1000;
        // 
        StTest = 50;
    }

    //public void Demage(int _Dmg)
    //{
    //    HP -= _Dmg;
    //}

}

namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player.Demage(NewPlayer, 100);
            //NewPlayer2.Demage(100);
            NewPlayer2.Heal( 100);

            Player.PVP(NewPlayer, NewPlayer1);
        }
    }
}
