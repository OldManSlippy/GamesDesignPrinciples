using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public struct Player
        {
            public string Name;
            public int Str;
            public int Con;
            public int Dex;
            public int Intelligence;
            public int Wis;
            public int Cha;
            
        }
    class Program
    {

        static void Main(string[] args)
        {
            Player Character;

            Character.Name = Console.ReadLine();
            Character.Str = 10;
            Character.Con = 10;
            Character.Dex = 80085;
            Character.Intelligence = 5;
            Character.Wis = 10;
            Character.Cha = 10;
            Console.WriteLine("Name: {0}\t Str: {1}\t Con: {2}\t Dex: {3}");
            Console.ReadLine();
        }
    }
}
