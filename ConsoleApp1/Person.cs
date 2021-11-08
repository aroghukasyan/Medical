using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Person
    {
        private const byte _maxFirstnameLength = 80;
        private const byte _maxLastnameLength = 120;
        private const byte _minFirstnameLength = 2;
        private const byte _minLastnameLength = 2;

        private const byte _maxAge = 120;
        private const byte _minAge = 0;

        public string Lastname { get; set; }
        public String Firstname { get; set; }
        public int Age { get; set; }
        public Person(String firstname, String lastname, int age) : this(firstname, lastname)
        {
            if(age >= _minAge && age <= _maxAge)
            {
                Age = age;
            } else
            {
                throw new Exception("Age does not match reality");
            }
        }
        public Person(String firstname, String lastname) : this(lastname)
        {
            if (firstname.Length > _minFirstnameLength && firstname.Length <= _maxFirstnameLength)
            {
                Firstname = firstname;
            }
            else
            {
                throw new Exception("Firstnam does not match reality");
            }
        }
        public Person(String lastname)
        {
            if (lastname.Length >= _minLastnameLength && lastname.Length <= _maxLastnameLength)
            {
                Lastname = lastname;
            }
            else
            {
                throw new Exception("Lastname does not match reality");
            }
        }
    }
}
