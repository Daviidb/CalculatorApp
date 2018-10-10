using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary
{
    public class Functions
    {
        public static string Plus(double plus)
        {
            return "Resultat: " + plus;
        }
        public static string Minus(double minus)
        {
            return "Resultat: " + minus;
        }
        public static string Gange(double gange)
        {
            return "Resultat: " + gange;
        }
        public static string Dividere(double dividere)
        {
            return "Resultat: " + dividere;
        }

        public static int Sum(int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum = sum + ints[i];
            }

            return sum;
        }

        public static double Average(int[] ints)
        {
            double average = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                average = average + ints[i];
            }

            return average / ints.Length;

        }

        public static double Average2(List<double> average2)
        {
            double average = average2[0];
            for (int i = 1; i < average2.Count; i++)
            {
                average = average + average2[i];
            }

            return average / average2.Count;

        }

        public static int Minimum(int[] ints)
        {
            int lowestvalue = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (lowestvalue > ints[i])
                {
                    lowestvalue = ints[i];
                }
            }

            return lowestvalue;
        }

        public static double Minimum2(List<double> minimum2)
        {
            double lowestvalue = minimum2[0];
            for (int i = 0; i < minimum2.Count; i++)
            {
                if (lowestvalue > minimum2[i])
                {
                    lowestvalue = minimum2[i];
                }
            }

            return lowestvalue;
        }

        public static int Maximum(int[] ints)
        {
            int highestvalue = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (highestvalue < ints[i])
                {
                    highestvalue = ints[i];
                }
            }

            return highestvalue;
        }

        public static double Sum2(List<double> sum2)
        {
            double sum = 0;
            for (int i = 0; i < sum2.Count; i++)
            {
                sum = sum + sum2[i];
            }

            return sum;
        }

        public static double Maximum2(List<double> maximum2)
        {
            double highestvalue = maximum2[0];
            for (int i = 0; i < maximum2.Count; i++)
            {
                if (highestvalue < maximum2[i])
                {
                    highestvalue = maximum2[i];
                }
            }

            return highestvalue;
        }

    }
}
