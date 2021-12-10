using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator_uppgift
{
    class Program
    {
       // Calculator basic operations assignment (Maqsood-ul hasan)
        static void Main(string[] args)
        {
            double Value1 = 0;
            double Value2 = 0;
            string Val = "";
            Console.WriteLine("Välja e - Stäng program");
            Console.WriteLine("Välja operation från +, -, * , /");
            Console.WriteLine("**********************************");

            while (true)
            {
                Console.Write("Press any key to continue or 'n' to EXIT y/n: " );
                if((Console.ReadLine()) == "n")
                {
                    Environment.Exit(0);
                }

                Console.Write("Press c to clear history or any key to continue: ");
                if ((Console.ReadLine()) == "c")
                {
                    Clearhistory();
                }
                try
                {
                    Console.Write("Enter the first value: ");
                    Value1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Operation to perform: ");
                    Val = Console.ReadLine().Trim();

                    if (Val == " ")
                    {
                        Console.WriteLine("Välja rätt math function från +, -, * , /");
                    }
                    else if (Val == "e")
                    {
                        Environment.Exit(0);
                    }
                    Console.Write("Enter the second value: ");
                    Value2 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message); 
                }
                 
                switch (Val)
                {

                    case "e":
                        Environment.Exit(0);
                        break;
                    case "+":
                        Console.WriteLine("Result is = {0:0.00}", AddNumbers(Value1, Value2));
                        break;
                    case "-":
                        Console.WriteLine("Result is = {0:0.00}", SubtractNumbers(Value1, Value2));
                        break;

                    case "*":
                        Console.WriteLine("Result is = {0:0.00}", MultiplyNumbers(Value1, Value2));
                        break;

                    case "/":
                        Console.WriteLine("Result is = {0:0.00}", DivideNumbers(Value1, Value2));
                        break;
                    case "c":
                        Clearhistory();
                        break;
                   
                    default:
                        Console.WriteLine("välja rätt val");
                        break;
                }
            }

        }
                       
        public static double AddNumbers(double a, double b)
        {
            return (a + b);
            //Console.WriteLine ("Result is = {0:0.00}", a + b );
            
        }
        
        public static double SubtractNumbers(double a, double b)
        {
            return (a - b);
        }

        public static double MultiplyNumbers(double a, double b)
        {
            return (a * b);
        }

        public static double DivideNumbers(double a, double b)
        {
            if(a == 0 || b == 0)
            {
               Console.WriteLine("OBS: Division with Zero can not be performed");
                return 0.00;
            }
            else
            {
                return (a / b);
            }
            
        }

        static void Clearhistory ()  //function to clear previous calculation in console window
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
