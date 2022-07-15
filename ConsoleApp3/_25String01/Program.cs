using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//프로그래밍에 있어서 기본기라고 생각하는 3가지
//언어는 숨쉬는 것.

namespace _25String01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //int는 구조체고 내부의 멤버변수나 함수가 존재하고
            //그것을 통해서 문자열로 변환을 해줄 수 있다.
            int AAA = new int();
            AAA = 100;
            char Charactor = 'a';
            string TEST = "afdsaffdsfdsafdsa";
            string Left = "안녕하세요";
            string Right = "날씨가 좋네요";

            string Result = Left + Right + AAA.ToString();

            Console.WriteLine(Result);
            //자료형은 C#에서 만들어 놓은 기본구조체이다.
            //자료형이 다르면 C#은 대입할 수 없다.
            Console.WriteLine(TEST);

        }
    }
}
