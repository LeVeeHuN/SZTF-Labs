using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class IOHelper : IIOHelper
    {
        public string GetUserInput()
        {
            string input;
            do
            {
                Console.WriteLine("Fájl(0) vagy konzol(1) input? ");
                input = Console.ReadLine();
            } while (!input.Equals("0") && !input.Equals("1"));

            if (input.Equals("0"))
            {
                // TODO: fájlból
                Console.WriteLine("Fájl neve: ");
                return File.ReadAllText(Console.ReadLine());
            }
            else
            {
                // TODO: konzolrol
                Console.WriteLine("Input: ");
                return Console.ReadLine();
            }
        }
    }
}
