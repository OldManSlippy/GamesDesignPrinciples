using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        static int Action;
        enum NPC_Action
        {
            stationary,
            run,
            walk,
            hide,
            shoot,
            die
        };
        static void Main(string[] args)
        {
            Action = 0;
            Action = Convert.ToInt32(Console.ReadLine());
 
            if (Action == (int)NPC_Action.walk)
            {
                Console.WriteLine("NPC is Walking.");
                Console.WriteLine((int)NPC_Action.walk);
            }
            if (Action == (int)NPC_Action.die)
            {
                Console.WriteLine("NPC died.");
            }
            Console.ReadLine();
        }
    }
}
