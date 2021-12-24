using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator_uppgift
{
    public class MathFunctions
    {
        public static double AddNumbers(double a, double b)
        {
            return Math.Round((a + b),2);
            //Console.WriteLine ("Result is = {0:0.00}", a + b );

        }
        public static double AddNumbers(double[] InputArray)
        {
            double result = 0;
            foreach (double item in InputArray)
            {
                result += item;
            }
            return Math.Round((result),2);

        }

        public static double SubtractNumbers(double a, double b)
        {
            return Math.Round((a - b),2);
        }
        public static double SubtractNumbers(double[] InputArray)
        {
            double result = 0;
            foreach (double item in InputArray)
            {
                result -= item;
            }
            return Math.Round((result),2);
        }

        public static double MultiplyNumbers(double a, double b)
        {
            return Math.Round((a * b),2);
        }

        public static double DivideNumbers(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("OBS: Division with Zero can not be performed");
                return 0.00;
            }
            else
            {
                return Math.Round((a / b),2);
            }

        }

        public static void Clearhistory()  //function to clear previous calculation in console window
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, 3);

            //Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 3; i <= currentLineCursor; i++)
            {
                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    Console.Write(new string(' ', Console.WindowWidth));
                }
            }
            Console.SetCursorPosition(0, 3);
            Console.SetWindowPosition(0, 0);

        }
    }
}
