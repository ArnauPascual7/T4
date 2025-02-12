using System;
namespace T4_Activitats
{
    public class SalesEmployee : Employee
    {
        public float Commission { get; set; }

        public SalesEmployee(string code, string firstname, string lastname, DateTime birthDate, DateTime hireDate, float monthSalary, int payments, float commission)
            : base(code, firstname, lastname, birthDate, hireDate, monthSalary, payments) => Commission = commission;
        public SalesEmployee(string code, string firstname, string lastname, DateTime birthDate, DateTime hireDate, float monthSalary, float commission)
            : base(code, firstname, lastname, birthDate, hireDate, monthSalary) => Commission = commission;
        public SalesEmployee(string code, string firstname, string lastname, DateTime birthDate, DateTime hireDate, int payments, float commission)
            : base(code, firstname, lastname, birthDate, hireDate, payments) => Commission = commission;
        public SalesEmployee(string code, string firstname, string lastname, DateTime birthDate, DateTime hireDate, float commission)
            : base(code, firstname, lastname, birthDate, hireDate) => Commission = commission;

        public override string ToString()
        {
            return base.ToString() + $"\n>Commission: {Commission}";
        }
    }
}
