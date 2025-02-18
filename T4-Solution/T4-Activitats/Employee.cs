﻿using System;
namespace T4_Activitats
{
    public class Employee
    {
        public static int Employees { get; private set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthSalary { get; set; } = 1800;
        public int Payments { get; set; } = 14;

        public Employee(string code, string firstname, string lastname, DateTime birthDate, DateTime hireDate, float monthSalary, int payments)
            : this (code, firstname, lastname, birthDate, hireDate)
        {
            MonthSalary = monthSalary;
            Payments = payments;
        }
        public Employee(string code, string firstname, string lastname, DateTime birthDate, DateTime hireDate, float monthSalary)
            : this (code, firstname, lastname, birthDate, hireDate)
        {
            MonthSalary = monthSalary;
        }
        public Employee(string code, string firstname, string lastname, DateTime birthDate, DateTime hireDate, int payments)
            : this (code, firstname, lastname, birthDate, hireDate)
        {
            Payments = payments;
        }
        public Employee(string code, string firstname, string lastname, DateTime birthDate, DateTime hireDate)
        {
            Code = code;
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthDate;
            HireDate = hireDate;
            Employees ++;
        }

        public string GetFullName() => $"{FirstName} {LastName}";
        public string GetReverseFullName() => $"{LastName}, {FirstName}";
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (BirthDate.Month > today.Month || (BirthDate.Month == today.Month && BirthDate.Day > today.Day)) age--;
            return age;
        }
        public int GetYearsWorrking()
        {
            DateTime today = DateTime.Today;
            int years = today.Year - HireDate.Year;
            if (HireDate.Month > today.Month || (HireDate.Month == today.Month && HireDate.Day > today.Day)) years--;
            return years;
        }
        public float GetYearSalary() => MonthSalary * 12;
        public override string ToString()
        {
            return
                "-----------------------------------------------------------------------------------------------------\n" +
                "                           E M P L O Y E E / S A L E S E M P L O Y E E\n" +
                "-----------------------------------------------------------------------------------------------------\n" +
                $">Code: {Code}\n" +
                $">Firstname: {FirstName}\n" +
                $">Lastname: {LastName}\n" +
                $">Full name: {GetFullName()}\n" +
                $">Reverse name: {GetReverseFullName()}\n" +
                $">Age: {GetAge()}\n" +
                $">Seniority: {GetYearsWorrking()}\n" +
                $">Annual salary: {GetYearSalary()}";
        }
    }
}
