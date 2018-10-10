using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bindings;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        List<string> menuStruktur = new List<string>();
        List<string> menuIDs = new List<string>();
        public void LoadMenu(string path)
        {
            if(path == null)
            {
                Console.WriteLine("Fejlagtigt Input");
            }

            else
            {
                System.IO.StreamReader menuspec = new System.IO.StreamReader(@"../../../SmartMenuLibrary/" + path);
                menuStruktur.Add(menuspec.ReadLine());
                menuStruktur.Add("");
                string line = null;
                string slut = menuspec.ReadLine();
                int counter = 1;

                while ((line = menuspec.ReadLine()) != null)
                {
                    string[] split = line.Split(';');
                    menuStruktur.Add(counter + ". " + split[0]);
                    menuIDs.Add(split[1]);
                    counter++;
                }

                menuStruktur.Add("");
                menuspec.Close();
                menuStruktur.Add(slut);
            }

        }
        public void Activate()
        {
            Binding binding = new Binding();
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                menuStruktur.ForEach(Console.WriteLine);
                int.TryParse(Console.ReadLine(), out int parsedinput);
                switch (parsedinput)
                {
                    case 0:
                    Console.WriteLine("Tryk 'Enter' igen for at afslutte");
                    menu = false;
                    break;
                    case 1:
                        binding.MenuID(menuIDs[0]);
                        break;
                    case 2:
                        binding.MenuID(menuIDs[1]);
                        break;
                    case 3:
                        binding.MenuID(menuIDs[2]);
                        break;
                    case 4:
                        binding.MenuID(menuIDs[3]);
                        break;
                    case 5:
                        binding.MenuID(menuIDs[4]);
                        break;
                    case 6:
                        binding.MenuID(menuIDs[5]);
                        break;
                    case 7:
                        binding.MenuID(menuIDs[6]);
                        break;
                    case 8:
                        binding.MenuID(menuIDs[7]);
                        break;
                    case 9:
                        binding.MenuID(menuIDs[8]);
                        break;
                    case 10:
                        binding.MenuID(menuIDs[9]);
                        break;
                    case 11:
                        binding.MenuID(menuIDs[10]);
                        break;
                    case 12:
                        binding.MenuID(menuIDs[11]);
                        break;

                }
                Console.ReadLine();
            }
        }

        public string Sprog(int sprogvalg)
        {
            if (sprogvalg == 1)
            {
                return "MenuSpecDK.txt";
            }
            else if(sprogvalg == 2)
            {
                return "MenuSpecENG.txt";
            }
            return null;
        }
    }
}
