using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.TurtleLib;

namespace Turtle22
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to run \nmain 1 (Turtle) or \n2 (Bucket)?\n3 (Frog)?" +
                "\n\n\n\t\ttype 1, 2, or 3");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Main1();
            }
            else if (n == 2)
                Main2();
            else if (n == 3)
                Main3();
            else
                Console.WriteLine("You selected an invalid option");
        }



    }
}
