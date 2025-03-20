namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Arithmetic_operations ao = new Arithmetic_operations();
            Console.WriteLine("welcome to calculator");
           
            Console.WriteLine("Do you want to continue? Y/N");
            string choice = Console.ReadLine();
            if (choice == "N" || choice == "n")
            {
                Console.WriteLine("goodbye");
                return;
            }
            else
            {
                Console.WriteLine("welcome back");
                Console.WriteLine(@"Any mathematical operation
                      you want to perform on two numbers can be done here
                           a for addition 
                           s for subtraction 
                           m for multiplication
                           d for division 
                           mo for modulus
                           p for power
                           sr for square root
                           cr for cube root
                           f for factorial
                           l for log
                            l10 for log10
                            si for sin
                            co for cos
                            ta for tan
                            as for arcsin
                            ac for arccos
                            at for arctan
                            ab for abs
                            ce for ceil
                            fl for floor
                            ro for round
                            ma for max
                            mi for min ");
                var operation = Console.ReadLine();
                if (operation == "a")
                {
                    Console.WriteLine("please enter first number");

                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }

                    Console.WriteLine("please enter second number");
                    while (!int.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the sum of {a} and {b} is {ao.Add(a, b)}");
                }
                else if (operation == "s")
                {
                    Console.WriteLine("please enter first number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine("please enter second number");
                    while (!int.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the subtraction of {a} and {b} is {ao.Subtract(a, b)}");
                }
                else if (operation == "m")
                {
                    Console.WriteLine("please enter first number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine("please enter second number");
                    while (!int.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the multiplication of {a} and {b} is {ao.Multiply(a, b)}");
                }
                else if (operation == "d")
                {
                    Console.WriteLine("please enter first number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine("please enter second number");
                    
                    while (!int.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    if (b == 0)
                    {
                        Console.WriteLine("cannot divide by zero");
                        return;
                    }
                    Console.WriteLine($"the division of {a} and {b} is {ao.Divide(a, b)}");
                }
                else if (operation == "mo")
                {
                    Console.WriteLine("please enter first number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine("please enter second number");
                    while (!int.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the mod of {a} and {b} is {ao.Mod(a, b)}");
                }
                else if (operation == "p")
                {
                    Console.WriteLine("please enter first number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine("please enter second number");
                    while (!int.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the power of {a} and {b} is {ao.Power(a, b)}");
                }
                else if (operation == "sr") 
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the square root of {a}  is {ao.SquareRoot(a)}");
                }
                else if (operation == "cr")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the cube root of {a}  is {ao.CubeRoot(a)}");
                }
                else if (operation == "f")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the sum of {a} and  is {ao.Factorial(a)}");
                }
                else if (operation == "l")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the log of {a} and  is {ao.Log(a)}");
                }
                else if (operation == "l10")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the log10 of {a} and  is {ao.Log10(a)}");
                }
                else if (operation == "si")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the sin of {a} and  is {ao.Sin(a)}");
                }
                else if (operation == "co")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the cos of {a} and  is {ao.Cos(a)}");
                }
                else if (operation == "ta")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the tan of {a} and  is {ao.Tan(a)}");
                }
                else if (operation == "as")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the asin of {a} and  is {ao.Asin(a)}");
                }
                else if (operation == "ac")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the acos of {a} and  is {ao.Acos(a)}");
                }
                else if (operation == "at")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the atan of {a} and  is {ao.Atan(a)}");
                }
                else if (operation == "ab")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the abs of {a} and  is {ao.Abs(a)}");
                }
                else if (operation == "ro")
                {
                    Console.WriteLine("please enter first number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the round of {a} and  is {ao.Round(a)}");
                }
                else if (operation == "ma")
                {
                    Console.WriteLine("please enter first number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine("please enter second number");
                    while (!int.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the max of {a} and {b} is {ao.Max(a, b)}");
                }
                else if (operation == "mi")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine("please enter second number");
                    while (!int.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the min of {a} and {b} is {ao.Min(a, b)}");
                }
                else if (operation == "ce")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the ceil of {a} and  is {ao.Ceil(a)}");
                }
                else if (operation == "fl")
                {
                    Console.WriteLine("please enter  number");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                    }
                    Console.WriteLine($"the floor of {a} and  is {ao.Floor(a)}");
                }
                else
                {
                    Console.WriteLine("invalid operation");
                }

               
            }
           Console.WriteLine("press esc to exit");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("press esc to exit");
            }
            
            Console.ReadLine();


           
            
        }
    }
}
