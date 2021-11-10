using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Doctor : Person, IPrintable
        {
        public int Id { get; }
        private static int id = 0;
        public MedicalSpecialties Speciality { get; set; }
        public List<Patient> Patients { get; set; }
        public List<PatientRecipe> PatientRecipes { get; set; }
        public Doctor(String firstname, String lastname, int age) : base(firstname, lastname, age) 
        {
            id++;
            Id = id;
            Patients = new List<Patient>();
            PatientRecipes = new List<PatientRecipe>();
        }
        public void TryAssignePatient(Patient doctor)
        {
            if (!Patients.Contains(doctor))
            {
                Patients.Add(doctor);
            }
        }
        public void AssigneRecipe(Patient patient, Recipe recipe)
        {
            if(patient is null || recipe is null)
            {
                throw new NullReferenceException("In AssigneRecipe time null reference patient or recipe");
            }
            else
            {
                PatientRecipe temp = new PatientRecipe() { Patient = patient, Recipe = recipe };
                PatientRecipes.Add(temp);
                DoctorRecipe doctorRecipe = new DoctorRecipe() { doctor = this, recipe = recipe };
                patient.DoctorRecipes.Add(doctorRecipe);
            }
        }

        public void Print()
        {
            Console.WriteLine($"Doctor: {this.Id} | {this.Firstname} {this.Lastname} | Age is {this.Age}");
        }

        public void PrintDeep()
        {
            Console.WriteLine($"Doctor: {this.Id} | {this.Firstname} {this.Lastname} | Age is {this.Age}");
            Console.WriteLine("Doctor patients: ");
            foreach (var item in Patients)
            {
                Console.WriteLine($"{item.Id} | {item.Firstname} {item.Lastname} | Age is {item.Age}");
            }
        }
    }
  
}
