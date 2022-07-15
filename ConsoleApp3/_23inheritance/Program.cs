using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//방법은
//공콩되는 기능을 하는 멤버변수와
//멤버함수를 걷어낸다.
//상송을 여러개 받는 언어도 존재하지만 C#은 아니다.
class FightUnit
{
    protected int AT = 10;
    protected int HP = 100;

    public void Damage(FightUnit OtherUnit)//업캐스팅:자식 클래스가 부모클래스의 인자값이 되어 자신의 클래스의 기능을 잃고 부모형이 됨
    {
        this.HP -= OtherUnit.AT;
    }
}

class Player : FightUnit
{
    int Lv = 1;

    void Heal()
    {
        HP = 100;
    }
}
class Monster : FightUnit
{
    int Exp = 10;
}

namespace _23inheritance
{

    //상속이란 
    //코드 재활용성을 향상시키기 위해서
    //(똑같은 코드 2번 치기 싫다.)
    //어떤 계열이 있느냐를 파악하는 감.

    class Program
    {
        static void Main(string[] args)
        {
            Player P = new Player();
            Monster M = new Monster();
            P.Damage(M);
        }
    }
}
