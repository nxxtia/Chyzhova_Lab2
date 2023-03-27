using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab02;

namespace Lab02
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public bool IsAdult
        {
            get
            {
                return CalculateAge() >= 18;
            }
        }

        public string SunSign
        {
            get
            {
                return ZodiacHelper.GetWesternZodiacSign(DateOfBirth);
            }
        }

        public string ChineseSign
        {
            get
            {
                return ZodiacHelper.GetChineseZodiacSign(DateOfBirth);
            }
        }

        public bool IsBirthday
        {
            get
            {
                return DateOfBirth.Day == DateTime.Now.Day && DateOfBirth.Month == DateTime.Now.Month;
            }
        }

        private int CalculateAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                age -= 1;

            return age;
        }
    }
}
