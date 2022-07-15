using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct StructData
{
    //구조체는 리터럴 초기화가 안된다.
    public int a;
    public int b;

    public void Func()
    {
        
    }
}
namespace _21Struct
{
    class Program
    {
        static void Test(StructData _Data)
        {
            _Data.a = 1000;
        }
        static void Main(string[] args)
        {
            int Number = 100;
            StructData NewData = new StructData();
            NewData.Func();
        }
    }
}
