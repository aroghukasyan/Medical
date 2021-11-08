using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Patient : Person
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
        //public AssineD
    }
}
