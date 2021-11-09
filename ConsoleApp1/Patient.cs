using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Patient : Person, IPrint
    {
        public int Id { get; }
        private static int id = 0; 
        public Boolean Gender { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<DoctorRecipe> DoctorRecipes { get; set; }

        public Patient(String firstname, String lastname, int age) : base(firstname, lastname, age) 
        {
            id++;
            Id = id;
            Doctors = new List<Doctor>();
            DoctorRecipes = new List<DoctorRecipe>();
        }
        public void TryAssigneDoctor(Doctor doctor)
        {
            if (!Doctors.Contains(doctor))
            {
                Doctors.Add(doctor);
            }
        }

        public void Print()
        {
            Console.Write($"Patient: {this.Id} | {this.Firstname} {this.Lastname} | Age is {this.Age} Gender is: ");
            Console.WriteLine((Gender) ? "Male" : "Famale");

        }

        public void PrintDeep()
        {
            Console.Write($"Patient: {this.Id} | {this.Firstname} {this.Lastname} | Age is {this.Age} Gender is: ");
            Console.WriteLine((Gender) ? "Male" : "Famale");
            Console.WriteLine("Patient doctors: ");
            foreach (var item in Doctors)
            {
                Console.WriteLine($"{item.Id} | {item.Firstname} {item.Lastname} | Age is {item.Age}");
            }
            Console.WriteLine("Patient recipe: ");
            foreach (var item in DoctorRecipes)
            {
                item.Print();
            }
        }
    }
}
