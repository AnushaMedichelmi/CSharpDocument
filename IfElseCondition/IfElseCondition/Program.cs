using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            if (age > 18)
            {
                Console.WriteLine("Eligible for voting");
            }
            else
            {
                Console.WriteLine("Not eligible for voting");
            }
        }
    }
}
