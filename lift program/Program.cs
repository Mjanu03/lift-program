using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;

namespace lift_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = 1, x, c1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("WELCOME TO  CIET LIFT ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lift range should be... ");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("CHOOSE THE THE FLOOR..");
            c1 = Convert.ToInt32(Console.ReadLine());
       
            Console.Clear();
            switch (c1)
            {
                case 1:

                    while (d < c1)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Arrived floor" + d);
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Departure  floor" + d);
                        Thread.Sleep(1000);
                        d++;
                        Console.Clear();
                    }
                    Console.WriteLine("Arrived..Floor " + c1);
                    
                    Console.WriteLine("Do you want move another floor ");
                    Console.WriteLine("1.Yes");
                    Console.WriteLine("2.No");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Console.WriteLine("Choose the Floor");
                        Console.WriteLine("1");
                        Console.WriteLine("2");
                        Console.WriteLine("3");
                        Console.WriteLine("4");
                        Console.WriteLine("5");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (m > c1)
                        {
                            for (int i = c1 + 1; i <= m; i++)
                            {
                                Console.WriteLine("Departure  floor" + (i - 1));
                                Thread.Sleep(1000);
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine("Thanks for visit us...");
                        }
                        else if (m < c1)
                        {
                            for (int i = c1 - 1; i >= m; i--)
                            {
                                Console.WriteLine("Departure  floor" + (i + 1));
                                Thread.Sleep(1000);
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine("Thanks for visit us...");

                        }


                    }
                    else
                    {

                        Console.WriteLine("Departure  floor" + c1);


                    }

                    break;
                case 2:

                    while (d < c1)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Arrived floor" + d);
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Departure  floor" + d);
                        d++;
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Console.WriteLine("Arrived..Floor " + c1);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Do you want move up (or) down floor ");
                    Console.WriteLine("1.Yes");
                    Console.WriteLine("2.No");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Console.WriteLine("Choose the floor");
                        Console.WriteLine("1");
                        Console.WriteLine("2");
                        Console.WriteLine("3");
                        Console.WriteLine("4");
                        Console.WriteLine("5");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (m > c1)
                        {
                            for (int i = c1 + 1; i <= m; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Departure  floor" + (i - 1));
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            Console.WriteLine("Thanks for visit us...");
                        }
                        else if (m < c1)
                        {
                            for (int i = c1 - 1; i >= m; i--)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Departure  floor" + (i + 1));
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            Console.WriteLine("Thanks for visit us...");

                        }


                    }
                    else
                    {

                        Console.WriteLine("Departure  floor" + c1);


                    }

                    break;
                case 3:

                    while (d < c1)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Arrived floor" + d);
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Departure  floor" + d);
                        d++;
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Console.WriteLine("Arrived..Floor " + c1);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Do you want move up (or)down floor ");
                    Console.WriteLine("1.Yes");
                    Console.WriteLine("2.No");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Choose the floor");
                        Console.WriteLine("1");
                        Console.WriteLine("2");
                        Console.WriteLine("3");
                        Console.WriteLine("4");
                        Console.WriteLine("5");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (m > c1)
                        {
                            for (int i = c1 + 1; i <= m; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Departure  floor" + (i - 1));
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            Console.WriteLine("Thanks for visit us...");
                        }
                        else if (m < c1)
                        {
                            for (int i = c1 - 1; i >= m; i--)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Departure  floor" + (i + 1));
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            Console.WriteLine("Thanks for visit us...");

                        }


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Departure  floor" + c1);


                    }

                    break;
                case 4:

                    while (d < c1)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Arrived floor" + d);
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Departure  floor" + d);
                        d++;
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Console.WriteLine("Arrived..Floor " + c1);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Do you want move another floor ");
                    Console.WriteLine("1.Yes");
                    Console.WriteLine("2.No");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Choose the floor");
                        Console.WriteLine("1");
                        Console.WriteLine("2");
                        Console.WriteLine("3");
                        Console.WriteLine("4");
                        Console.WriteLine("5");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (m > c1)
                        {
                            for (int i = c1 + 1; i <= m; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Departure  floor" + (i - 1));
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            Console.WriteLine("Thanks for visit us...");
                        }
                        else if (m < c1)
                        {
                            for (int i = c1 - 1; i >= m; i--)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Departure  floor" + (i + 1));
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            Console.WriteLine("Thanks for visit us...");

                        }


                    }
                    else
                    {

                        Console.WriteLine("Departure  floor" + c1);


                    }

                    break;
                case 5:

                    while (d < c1)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Arrived floor" + d);
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Departure  floor" + d);
                        d++;
                        Thread.Sleep(1000);
                        Console.WriteLine();
                    }
                    Console.WriteLine("Arrived..Floor " + c1);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Do you want move another floor ");
                    Console.WriteLine("1.Yes");
                    Console.WriteLine("2.No");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Choose the floor");
                        Console.WriteLine("1");
                        Console.WriteLine("2");
                        Console.WriteLine("3");
                        Console.WriteLine("4");
                        Console.WriteLine("5");
                        int m = Convert.ToInt32(Console.ReadLine());
                        if(m > c1)
                        {
                            for (int i = c1 + 1; i <= m; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Departure  floor" + (i - 1));
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            Console.WriteLine("Thanks for visit us...");
                        }
                        else if (m < c1)
                        {

                            for (int i = c1 - 1; i >= m; i--)
                            {


                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Departure  floor" + (i + 1));
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Arrived floor" + i);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            Console.WriteLine("Thanks for visit us...");

                        }


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Departure  floor" + c1);


                    }

                    break;
                default :
                     Console.WriteLine("Enter correct floor..");
                break;
 
            }
        }
    }
}       
            
              
            

        
       

        



















