using System;
using System.Security.Cryptography.X509Certificates;

namespace lab2_z2
{
    public class Program
    {
        static public double Equation(double a, double b, double dx)
        {
            double y = 0;
            double x = a;

             
            Console.WriteLine("Виберіть спосіб розрахунку\n 1: Цикл з передумовою\n 2: Цикл з постумовою");
            string InsertSwitch = Console.ReadLine();
            int SwitchNum = int.Parse(InsertSwitch);

            switch (SwitchNum)
            {
                case 1:
                    while (x <= b)
                    {
                        if (1 - Math.Sqrt(x) == 0)
                            Console.WriteLine("Ділення на нуль\n-----");
                        else
                        {
                            y = 1 / (1 - Math.Sqrt(x));
                            double roundY = Math.Round(y, 2);
                            Console.WriteLine(roundY);
                            Console.WriteLine("-----");
                        }

                        x += dx;
                    }
                    break;
                case 2:
                    do
                    {
                        if (1 - Math.Sqrt(x) == 0)
                            Console.WriteLine("Ділення на нуль\n-----");
                        else
                        {
                            y = 1 / (1 - Math.Sqrt(x));
                            double roundY = Math.Round(y, 2);
                            Console.WriteLine(roundY);
                            Console.WriteLine("-----");
                        }

                        x += dx;
                    } while (x <= b);
                    break;
                default:
                    Console.WriteLine("Невірне введення!");
                    break;
            }

            return y;

        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введiть мінімальний Х:");
                    string insertA = Console.ReadLine();
                    double a = double.Parse(insertA);

                    Console.WriteLine("Введiть максимальний Х:");
                    string insertB = Console.ReadLine();
                    double b = double.Parse(insertB);

                    Console.WriteLine("Введiть крок:");
                    string insertDX = Console.ReadLine();
                    double dx = double.Parse(insertDX);
                    Console.WriteLine("-----");

                    Equation(a, b, dx);
                    Console.ReadLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Дані некоректні, спробуйте ще");
                }
            }
        }
    }
}


