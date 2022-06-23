using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomina2
{
    internal class MenuPrincipal
    {
        public static void Main(string[] args)
        {
            Exercises Operations = new Exercises();

            Console.WriteLine("Main payroll");
            Console.WriteLine("1. Insert new employee");
            Console.WriteLine("2. Exit the main");

            string Opc = Console.ReadLine();

            int Opc1;

            switch(Opc)
            {

                case "1":
                    do
                    {
                        Operations.CalculatePayroll();
                        Operations.PrintDates();
                        Console.WriteLine("1. Insert new employee");
                        Console.WriteLine("2. Exit ");

                        Opc1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Data invalied");

                        Console.Clear();
                    }
                    while (Opc1 != 2);
                    break;

                    case "2":
                    Console.WriteLine("Exit");
                    break;

                    default:
                    Console.WriteLine("Exit of Console");
                    break;
            }



        }
    }
}
