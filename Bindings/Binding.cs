using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace Bindings
{
    public class Binding
    {
        public void MenuID(string menupunkt)
        {
          
            if (menupunkt == "Plus")
            {
                Console.Clear();
                Console.Write("Plus: ");
                string somethingline = Console.ReadLine();
                Console.Write("Med:");
                string somethingline2 = Console.ReadLine();
                double.TryParse(somethingline, out double add1);
                double.TryParse(somethingline2, out double add2);
                Console.WriteLine("");
                Console.WriteLine(Functions.Plus(add1 + add2));
                Console.WriteLine("");
                Console.WriteLine("Tryk 'Enter' for at vende tilbage.");
            }
            else if (menupunkt == "Minus")
            {
                Console.Clear();
                Console.Write("Minus: ");
                string somethingline = Console.ReadLine();
                Console.Write("Med:");
                string somethingline2 = Console.ReadLine();
                double.TryParse(somethingline, out double add1);
                double.TryParse(somethingline2, out double add2);
                Console.WriteLine("");
                Console.WriteLine(Functions.Minus(add1 - add2));
                Console.WriteLine("");
                Console.WriteLine("Tryk 'Enter' for at vende tilbage.");
            }
            else if (menupunkt == "Gange")
            {
                Console.Clear();
                Console.Write("Gange: ");
                string somethingline = Console.ReadLine();
                Console.Write("Med:");
                string somethingline2 = Console.ReadLine();
                double.TryParse(somethingline, out double add1);
                double.TryParse(somethingline2, out double add2);
                Console.WriteLine("");
                Console.WriteLine(Functions.Gange(add1 * add2));
                Console.WriteLine("");
                Console.WriteLine("Tryk 'Enter' for at vende tilbage.");
            }
            else if (menupunkt == "Dividere")
            {
                Console.Clear();
                Console.Write("Dividere: ");
                string somethingline = Console.ReadLine();
                Console.Write("Med:");
                string somethingline2 = Console.ReadLine();
                double.TryParse(somethingline, out double add1);
                double.TryParse(somethingline2, out double add2);
                Console.WriteLine("");
                Console.WriteLine(Functions.Dividere(add1 / add2));
                Console.WriteLine("");
                Console.WriteLine("Tryk 'Enter' for at vende tilbage.");
            }

            else if (menupunkt == "Sum")
            {
                Console.Clear();
                Console.WriteLine("Indtast tallene du vil finde summen af:");
                Console.WriteLine("(Afslut med Enter)");

                int[] array = new int[10];
                int keeprunning = 1;
                int i = 0;
                while (keeprunning == 1)
                {
                    if (i < 10)
                    {
                        string save = Console.ReadLine();
                        if (int.TryParse(save, out int savenumber))
                        {
                            array[i] = savenumber;
                            i++;
                        }
                        else if (save == "")
                        {
                            keeprunning = 0;
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt Nummer");
                            return;
                        }
                    }
                    else
                    {
                        keeprunning = 0;
                    }
                }
                Array.Resize(ref array, i);
                Console.WriteLine("Sum af talserie: " + Functions.Sum(array));
                Console.WriteLine("");
                Console.WriteLine("Tryk 'Enter' for at vende tilbage");
            }

            else if (menupunkt == "Sum2")
            {
                Console.Clear();
                Console.WriteLine("Indtast tallene du vil finde summen af:");
                Console.WriteLine("(Afslut med Enter)");

                List<double> liste = new List<double>();

                while (double.TryParse(Console.ReadLine(), out double r) != false)
                {
                    liste.Add(r);
                }
                Console.WriteLine("Sum af talserie: " + Functions.Sum2(liste));
            }

            else if (menupunkt == "Average")
            {
                Console.Clear();
                Console.WriteLine("Indtast tallene du vil finde gennemsnit af:");
                Console.WriteLine("(Afslut med Enter)");

                int[] array = new int[10];
                int keeprunning = 1;
                int i = 0;
                while (keeprunning == 1)
                {
                    if (i < 10)
                    {
                        string save = Console.ReadLine();
                        int savenumber;
                        if (int.TryParse(save, out savenumber))
                        {
                            array[i] = savenumber;
                            i++;
                        }
                        else if (save == "")
                        {
                            keeprunning = 0;
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt Nummer");
                            return;
                        }
                    }
                    else
                    {
                        keeprunning = 0;
                    }
                }
                Array.Resize(ref array, i);
                Console.WriteLine("Gennemsnit af talserie: " + Functions.Average(array));
                Console.WriteLine("");
                Console.WriteLine("Tryk 'Enter' for at vende tilbage");
            }

            else if (menupunkt == "Average2")
            {
                Console.Clear();
                Console.WriteLine("Indtast tallene du vil finde gennemsnittet af:");
                Console.WriteLine("(Afslut med Enter)");

                List<double> liste = new List<double>();

                while ((double.TryParse(Console.ReadLine(), out double r)) != false)
                {
                    liste.Add(r);
                }
                Console.WriteLine("Gennemsnit af talserie: " + Functions.Average2(liste));
            }

            else if (menupunkt == "Minimum")
            {
                Console.Clear();
                Console.WriteLine("Indtast tallene du vil finde minimum af:");
                Console.WriteLine("(Afslut med Enter)");

                int[] array = new int[10];
                int keeprunning = 1;
                int i = 0;
                while (keeprunning == 1)
                {
                    if (i < 10)
                    {
                        string save = Console.ReadLine();
                        int savenumber;
                        if (int.TryParse(save, out savenumber))
                        {
                            array[i] = savenumber;
                            i++;
                        }
                        else if (save == "")
                        {
                            keeprunning = 0;
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt Nummer");
                            return;
                        }

                    }
                    else
                    {
                        keeprunning = 0;
                    }
                }
                Array.Resize(ref array, i);
                Console.WriteLine("Minimum af talserie: " + Functions.Minimum(array));
                Console.WriteLine("");
                Console.WriteLine("Tryk 'Enter' for at vende tilbage");
            }

            else if (menupunkt == "Minimum2")
            {
                Console.Clear();
                Console.WriteLine("Indtast tallene du vil finde minimum af:");
                Console.WriteLine("(Afslut med Enter)");

                List<double> liste = new List<double>();

                while ((double.TryParse(Console.ReadLine(), out double r)) != false)
                {
                    liste.Add(r);
                }
                Console.WriteLine("Gennemsnit af talserie: " + Functions.Minimum2(liste));
            }

            else if (menupunkt == "Maximum")
            {
                Console.Clear();
                Console.WriteLine("Indtast tallene du vil finde maximum af:");
                Console.WriteLine("(Afslut med Enter)");

                int[] array = new int[10];
                int keeprunning = 1;
                int i = 0;
                while (keeprunning == 1)
                {
                    if (i < 10)
                    {
                        string save = Console.ReadLine();
                        int savenumber;
                        if (int.TryParse(save, out savenumber))
                        {
                            array[i] = savenumber;
                            i++;
                        }
                        else if (save == "")
                        {
                            keeprunning = 0;
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt Nummer");
                            return;
                        }
                    }
                    else
                    {
                        keeprunning = 0;
                    }
                }
                Array.Resize(ref array, i);
                Console.WriteLine("Maximum af talserie: " + Functions.Maximum(array));
                Console.WriteLine("");
                Console.WriteLine("Tryk 'Enter' for at vende tilbage");
            }


            else if (menupunkt == "Maximum2")
            {
                Console.Clear();
                Console.WriteLine("Indtast tallene du vil finde maximum af:");
                Console.WriteLine("(Afslut med Enter)");

                List<double> liste = new List<double>();

                while ((double.TryParse(Console.ReadLine(), out double r)) != false)
                {
                    liste.Add(r);
                }
                Console.WriteLine("Maximum af talserie: " + Functions.Maximum2(liste));
                Console.WriteLine("");
                Console.WriteLine("Tryk 'Enter' for at vende tilbage");
            }
        }
    }
}
