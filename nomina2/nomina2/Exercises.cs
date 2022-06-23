using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomina2
{
    internal class Exercises
    {
        Dates myData = new Dates();
        public void CalculatePayroll()
        {
            try
            {
                Console.WriteLine("Insert First Name: ");
                myData.FirstName = Console.ReadLine();

                Console.WriteLine("Insert Last Name: ");
                myData.LastName = Console.ReadLine();

                Console.WriteLine("Insert your Document: ");
                myData.Document1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Insert your Salary");
                myData.Salary1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Insert your Worked Days ");
                myData.WorkedDays = double.Parse(Console.ReadLine());
            }
            catch (Exception )
            {
                Console.WriteLine("Valor no valido, intente de nuevo");
            }

            myData.TotalAccrued1 = myData.Salary1 / 30;
            myData.TotalAccrued1 = myData.TotalAccrued1 * myData.WorkedDays;

            myData.Assitancetransport1 = 117172 / 30;
            myData.Assitancetransport1 = myData.Assitancetransport1 * myData.WorkedDays;

            myData.Health1 = myData.TotalAccrued1 * 0.04;
            myData.Pension1 = myData.TotalAccrued1 * 0.04;

            if(myData.Salary1 <= myData.SMLV1)
            {
                myData.TotalAccrued1 = myData.TotalAccrued1 + myData.Assitancetransport1;
            }
            else
            {
                myData.TotalAccrued1 = myData.TotalAccrued1;
            }

        }

        public void PrintDates()
        {
            Console.WriteLine("FirstName:" + myData.FirstName);
            Console.WriteLine("LastName:" + myData.LastName);
            Console.WriteLine("Document: " + myData.Document1);
            Console.WriteLine("Salary: " + myData.Salary1);
            Console.WriteLine("WorkedDays: " + myData.WorkedDays);
            Console.WriteLine("Pension: " + myData.Pension1);
            Console.WriteLine("Health: " + myData.Health1);
            Console.WriteLine("AssintanceTransport: " + myData.Assitancetransport1);
            Console.WriteLine("TotalAccrust: " + myData.TotalAccrued1);
        }


    }
}
