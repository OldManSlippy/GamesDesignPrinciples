using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2again
{
    class Program
    {
        string firstName = "Jane";
        string lastName = "Jonah Jameson";
        void Test()
        {
            Console.WriteLine("Name: " + firstName);
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        static void Main(string[] args)
        {
            Program Prog = new Program();
                string firstName = "Joseph";
            string lastName = "Jostar";

            Console.WriteLine("name: " + firstName + " " + lastName);

            Console.WriteLine("New name: " + firstName + " " + lastName);
            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            Prog.Test();

            Console.ReadLine();
        }
    }
}
