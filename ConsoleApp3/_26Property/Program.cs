using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{

    int AT = 10;
    public int HP=20;

    static int mStaticValue = 100;
    public static int StaticValue
    {
        get
        {
            return mStaticValue;
        }

        set
        {
            mStaticValue = value;
        }
    }

    //자료형을 선언했다면 이는 int와 관련된 함수라고 
    //명시하는것.
    public int ProAT
    {
        // 프로퍼티의 GET함수는 무조건 int를
        //리턴한다고 보고
        get
        {
            if (999 < AT)
            {
                Console.WriteLine("최대 수정치를 넘겼습니다.");
                while (true) { Console.ReadKey(); }
            }
            return AT;
        }
        //무조건 int하나가 들어온다고 생각한다.
        //그런 외부 값들을 프로퍼티에서는 
        //value라고 기호로 정의해 놨다.
        set
        {
            AT = value;
        }
    }

    int GetAT()
    {
        if (999 < AT)
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while (true) { Console.ReadKey(); }
        }
        return AT;
    }
    public void SetAT(int value)
    {
        if (999 < value)
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while (true){Console.ReadKey(); }
        }

        AT = value;
    }
}
   
namespace _26Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Player P = new Player();

            Player.StaticValue = 200;

            P.HP = 100;

            P.ProAT = 100;
            int PlayerAT = P.ProAT;
            //P.SetAT(10000000);
        }
    }
}
