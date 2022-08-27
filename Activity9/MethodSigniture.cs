using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9
{
    class MethodSigniture
    {

        //Method that takes two integers and displays their sum.
        public static int sum(int num1, int num2)
        {

            int sum = num1 + num2;

            return sum;
        }

        //Method that takes five doubles and returns their average.
        public static double average(double num1, double num2, double num3, double num4, double num5)
        {
            double average = (num1 + num2 + num3 + num4 + num5) / 5;
            return average;
        }

        //Method that returns the sum of two randomly generated integers.
        public static int sumRandom()
        {
            Random random = new Random();
            int num1 = random.Next(1, 1000);
            int num2 = random.Next(1, 1000);
            int sumRandom = num1 + num2;
            return sumRandom;
        }

        //Method that takes three integers and returns true if their sum is divisible by 3, false otherwise.
        public static bool sumDivsible(int num1, int num2, int num3)
        {
            int sumDivsible = (num1 + num2 + num3) % 3;
            return sumDivsible == 0;
        }

        //Method that takes two strings and displays the string that has fewer characters.
        public static string stringLength(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }


        //Method that takes an array of doubles and returns the largest value in the array.
        public static double arrLarge(double[] strLarge)
        {
            double largest = strLarge[0];
            for (int i = 0; i < strLarge.Length; i++)
            {
                if (strLarge[i] > largest)
                {
                    largest = strLarge[i];
                }
            }
            return largest;

        }

        //Method that generates and returns an array of fifty integer values.
        public static int[] arrFifty()
        {
            // declare array
            int[] arrFifty = new int[50];
            Random random = new Random();

            
            for (int i = 0; i < arrFifty.Length; i++)
            {
                arrFifty[i] = random.Next(10, 50);
            }

            return arrFifty;
        }

        //Method that takes two bool variables and returns true if they have the same value, false otherwise.
        public static bool sameValue(bool val1, bool val2)
        {
            if (val1 == val2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method that takes an int and a double and returns their product.
        public static double product(int num1, double num2)
        {
            double sumDoubleInt = num1 * num2;
            return sumDoubleInt;
        }

        //Method that takes a two-dimensional array of integers and returns the average of the entries.
        public static double arr2DAverage(double[,] a)
        {
            double sum = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }

            double average = sum / (a.GetLength(0) * a.GetLength(1));

            return average;
        }
    }
}