using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        static void ADD(int a, int b)
        {
            int add;
            add = a + b;
            Console.WriteLine(add);
        }
        static void SUB(int a, int b)
        {
            int sub;
            sub = a - b;
            Console.WriteLine(sub);
        }
        static void MUL(int a, int b)
        {
            int mul;
            mul = a * b;
            Console.WriteLine(mul);
        }


        static void Main(string[] args)
        {

            int[,] arr = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    arr[i, j] = i * j;
                    
                }
             
            }

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                   
                    Console.Write("{0}  X {1}  = {2}  ", j, i, arr[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }



        }

    }
}

