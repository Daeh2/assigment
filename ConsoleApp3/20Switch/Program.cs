using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int SwitchTest = 100;
            //Switch문은 ==연산만 가능하다.
            switch (SwitchTest)
            {
                case 0:
                    Console.WriteLine("SwitchTest는 0입니다.");
                    break;
                case 1:
                    Console.WriteLine("SwitchTest는 1입니다.");
                    break;
                case 100:
                    Console.WriteLine("SwitchTest는 100입니다.");
                    break;


               
            }
        }
    }
}
