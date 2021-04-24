using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Day, Time, Num = 0;
            string Menu;

            Console.Write("");
            Day = int.Parse(Console.ReadLine());
            Console.Write("");
            Time = int.Parse(Console.ReadLine());

            while (Day >= 1 && Day <= 7 && Time >= 8 && Time <= 18)
            {
                Console.Write("");
                Menu = Console.ReadLine();

                if (Menu == "Breakfast Set")
                {
                    if (Time > 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                    Num++;

                }
                else if (Menu == "End")
                {
                    Console.WriteLine("");
                    break;



                }
                else
                {
                    Console.WriteLine("Please enter a valid menu");
                }
            }
            if (Num == 6)
            {
                    Console.WriteLine("Sorry your order is out of stock");
            }
            else
            {
                    Console.WriteLine("");
            }

            while (Day >= 1 && Day <= 7 && Time >= 8 && Time <= 18)
            {
                    Console.Write("");
                    Menu = Console.ReadLine();

                    if (Menu == "Weekend Set")
                    {
                        if (Day >= 1 && Day <= 5)
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        else
                        {
                            Console.WriteLine("");
                        }

                        Num++;


                    }
                    else if (Menu == "End")
                    {
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid menu");
                    }
                    
            }
            if (Num == 3)
            {
                Console.WriteLine("Sorry your order is out of stock");
            }
            else
            {
                Console.WriteLine("");
            }

            while (Day >= 1 && Day <= 7 && Time >= 8 && Time <= 18)
            {
                    Console.Write("");
                    Menu = Console.ReadLine();

                    if (Menu == "Coffee")
                    {
                        Console.WriteLine("");

                        Num++;

                    }
                    else if (Menu == "End")
                    {
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid menu");
                    }

            }
            if (Num == 4)
            {
                Console.WriteLine("Sorry your order is out of stock");
            }
            else
            {
                Console.WriteLine("");
            }
                
            
            Console.ReadLine();
            
        }
    }
}
