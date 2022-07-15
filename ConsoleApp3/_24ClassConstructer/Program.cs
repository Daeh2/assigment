using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected int AT;

    public FightUnit()
    {
        int a = 0;
    }
}

class Player : FightUnit
{
    
    public Player()
    {
        AT = 100;
        int a = 0;
    }
}

namespace _24ClassConstructer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
