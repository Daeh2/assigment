using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    //객체화를 하지 않아도 플레이어의 내부는 내부이므로
    //접근제한 지정자에 영향을 받지 않는다.
    public static void PVP(Player _Left,Player _Rigth)
    {
        _Left.HP -= _Rigth.AT;
        _Rigth.HP-=_Left.AT;
    }
    private int HP = 100;
    private int AT = 100;
    public void Demage(Moster _Other)
    {
        HP -= 100;
    }
}

public class Moster
{
    private int AT;
    //public static void PVP(Player _Left, Player _Rigth)
    //{
    //    _Left.HP -= _Rigth.AT;
    //    _Rigth.HP -= _Left.AT;
    //}
}

namespace _14StaticFunc
{
    class Program
    {
        //이녀석도 클래스에 속한 정적 함수이다.
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Player NewPlayer1 = new Player();
            Player.PVP(NewPlayer, NewPlayer1);
            Console.WriteLine("d");
        }
    }
}
