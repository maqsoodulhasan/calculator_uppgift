using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static calculator_uppgift.MathFunctions;

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
            bool equationInput = false;
            double[] InputArray = new double[] { };
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
                    else if(Val == "+" || Val == "-")
                    {
                        Console.Write("press 2 to perform operation on 2 values or press 3 to perform on more than 2 values: ");
                        int ValueSelected = Convert.ToInt32(Console.ReadLine());
                        bool correctInput = false;
                        while (!(correctInput))
                        {
                            if (ValueSelected == 3)
                            {
                                equationInput = true;
                                Console.Write("Please enter all values with komma separated as a,b,c,d: ");
                                string InputString = Console.ReadLine().Trim();
                                InputArray = Array.ConvertAll(InputString.Split(','), Double.Parse);
                                correctInput = true;
                            }
                            else
                            {
                                Console.Write("Enter the first value: ");
                                Value1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter the second value: ");
                                Value2 = Convert.ToDouble(Console.ReadLine());
                                correctInput = true;
                            }
                        }
                        
                    }
                    else
                    {
                        Console.Write("Enter the first value: ");
                        Value1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the second value: ");
                        Value2 = Convert.ToDouble(Console.ReadLine());
                    }
                                       
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
                        if(equationInput)
                        {
                            Console.WriteLine("Result is = {0:0.00}", AddNumbers(InputArray));
                        }
                        else
                        {
                            Console.WriteLine("Result is = {0:0.00}", AddNumbers(Value1, Value2));
                        }
                        
                        break;
                    case "-":
                        if (equationInput)
                        {
                            Console.WriteLine("Result is = {0:0.00}", SubtractNumbers(InputArray));
                        }
                        else
                        {
                            Console.WriteLine("Result is = {0:0.00}", SubtractNumbers(Value1, Value2));
                        }
                        break;

                    case "*":
                        Console.WriteLine("Result is = {0:0.00}", MultiplyNumbers(Value1, Value2));
                        break;

                    case "/":
                        if(Value1 == 0 || Value2 == 0)
                        {
                            Console.WriteLine("Division with 0 is not allowed to perform:: select the correct input: ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Result is = {0:0.00}", DivideNumbers(Value1, Value2));
                        }
                        
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
                       
    }
}
