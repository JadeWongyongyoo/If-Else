using System;

namespace dif_else
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            mode = Console.ReadLine();
            double X, Y, T, P;
            X = double.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            P = (X - 1)*(X - 1);
            T = (Math.Sqrt(Y)+1);

            if (mode == "time" || mode == "price")
            {
                if (X < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
                else 
                {
                    if (mode == "time")
                    {
                        Console.Write("{0},{1}", X,P);
                    }
                    if (mode == "price")
                    {
                        Console.Write("{0},{1}", T,Y);
                    }
                }
            }
            else 
            {
                Console.WriteLine("Invalid mode");
                if (X < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
        }
    }
}
