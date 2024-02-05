using System;

namespace task1
{

    class Program
    {
        static void Main()
        {
            BasicCalculator calculator = new BasicCalculator();
            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("Welcome to calculator.... ");
                Console.WriteLine("\t1.Add");
                Console.WriteLine("\t2.Subtract");
                Console.WriteLine("\t3.Multiply");
                Console.WriteLine("\t4.Divide");
                Console.WriteLine("\t5.Modulo");
                Console.WriteLine("\t6.Square root");
                Console.WriteLine("\t7.Logarithm");
                Console.WriteLine("\t8.Exponent");
                Console.WriteLine("\t9.Trignomertic functions");
                Console.WriteLine("\t10.exit");
                Console.Write("Enter option....");
                int option = int.Parse(Console.ReadLine());
                
                if (option == 10)
                {
                    Console.Clear();
                }
                else if (option == 1)
                {
                    Console.WriteLine("Enter 1st number: ");
                    calculator.num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number: ");
                    calculator.num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result is: " + calculator.Add(calculator.num1, calculator.num2));


                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter 1st number: ");
                    calculator.num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number: ");
                    calculator.num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result is: " + calculator.Subtract(calculator.num1, calculator.num2));


                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter 1st number: ");
                    calculator.num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number: ");
                    calculator.num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result is: " + calculator.Multiply(calculator.num1, calculator.num2));


                }
                else if (option == 4)
                {
                    Console.WriteLine("Enter 1st number: ");
                    calculator.num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number: ");
                    calculator.num2 = double.Parse(Console.ReadLine());
                    if (calculator.num2 == 0)
                    {
                        Console.WriteLine("Cannot divide to zero...");
                    }
                    else
                    {
                        Console.WriteLine("Result is: " + calculator.Divide(calculator.num1, calculator.num2));
                    }

                }
                else if (option == 5)
                {
                    Console.WriteLine("Enter 1st number: ");
                    calculator.num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number: ");
                    calculator.num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result is: " + calculator.modulo(calculator.num1, calculator.num2));


                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter a number: ");
                    calculator.num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Result is: " + calculator.sr(calculator.num1));


                }

                else if (option == 7)
                {
                    Console.WriteLine("Enter a number: ");
                    calculator.num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Result is: " + calculator.lg(calculator.num1));


                }

                else if (option == 8)
                {
                    Console.WriteLine("Enter a number: ");
                    calculator.num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Result is: " + calculator.expo(calculator.num1));


                }

                else if (option == 9)
                {
                    Console.Write("Choose function......(...sin....cos....tan)");
                    string op = Console.ReadLine();
                    if (op == "sin" || op == "cos" || op == "tan")
                    {
                        Console.WriteLine("Enter a number: ");
                        calculator.num1 = double.Parse(Console.ReadLine());


                        if (op == "sin")
                        {
                            Console.WriteLine("Result is: " + calculator.sin(calculator.num1));
                        }
                        else if (op == "cos")
                        {
                            Console.WriteLine("Result is: " + calculator.cos(calculator.num1));
                        }
                        else if (op == "tan")
                        {
                            Console.WriteLine("Result is: " + calculator.tan(calculator.num1));
                        }

                    }
                    else { Console.WriteLine("Invalid function..!"); }



                }



                Console.ReadKey();
            }
        }
    }
}