using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int num;

            Console.WriteLine("Please enter an integer:");

            do
            {
                num = int.Parse(Console.ReadLine());

                Console.WriteLine("Number    Squared    Cubed\n======    =======    =====");
                
                for ( int i = 1; i <= num; i++)
                {
                    Console.WriteLine("{0,0}{1,10}{2,11}", i, SquareInput(i), CubeInput(i));
                }
                

                //ask user if they want to continue
                Console.WriteLine("Do you want to continue?");

                string input = Console.ReadLine();

                if (input.ToLower() == "no")
                    run = false;


            } while (run);
        }

        public static int SquareInput(int n)
        {
            int square = n * n;
            return square;
        }

        public static int CubeInput(int n)
        {
            int cube = n * n * n;
            return cube;
        }

    }
}
