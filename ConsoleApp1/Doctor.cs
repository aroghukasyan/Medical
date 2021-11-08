using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Doctor : Person
        {
        public int Id { get; }
        private static int id { get; set; } = 0;
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
            }
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
  
}
