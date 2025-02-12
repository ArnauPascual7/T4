using System;
namespace T4_Activitats
{
    public class Employee
    {
        public static int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Month > today.Month || (birthDate.Month == today.Month && birthDate.Day > today.Day)) age--;
            return age;
        }
    }
}
