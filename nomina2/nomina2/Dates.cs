using System;

namespace nomina2
{
    internal class Dates
    {
        private string firstName;
        private string lastName;
        private double Document;
        private double Salary;
        private double workedDays;
        private double Pension;
        private double Health;
        private double Assitancetransport;
        private double TotalAccrued;
        private double SMLV = 2000000;

        public Dates()
        {

        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Document1 { get => Document; set => Document = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double WorkedDays { get => workedDays; set => workedDays = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
        public double Health1 { get => Health; set => Health = value; }
        public double Assitancetransport1 { get => Assitancetransport; set => Assitancetransport = value; }
        public double TotalAccrued1 { get => TotalAccrued; set => TotalAccrued = value; }
        public double SMLV1 { get => SMLV; set => SMLV = value; }
    }
}