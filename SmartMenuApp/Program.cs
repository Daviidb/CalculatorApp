using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            Console.WriteLine("Vælg sprog  / Choose language");
            Console.WriteLine("");
            Console.WriteLine(" 1. Dansk");
            Console.WriteLine(" 2. English");
            Console.WriteLine("");
            Console.WriteLine("(Vælg menupunkt 1 eller 2 / Choose menu item 1 or 2)");
            string input = Console.ReadLine();
            int.TryParse(input, out int parsedinput);
            if (parsedinput == 0 || parsedinput > 2)
            {
                Console.WriteLine("Fejlagtigt Input");
            }
            else
            {
                menu.LoadMenu(menu.Sprog(parsedinput));
                menu.Activate();
            }
            
            

        }
    }
}
