using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace _Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
           
            
            Stack stack1 = new Stack(n);
            for(int i = 0; i < n; i++)
            {
                stack1.Push(Console.ReadLine());  
            }
            foreach (object obj in stack1)
            {
                Console.WriteLine($"value : {obj}");
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("peek한 스택 : {0}",stack1.Peek());
                Console.WriteLine("pop한 스택{0}",stack1.Pop());
            }
        }
    }
}
