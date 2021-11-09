using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DoctorRecipe
    {
        public Doctor doctor { get; set; }
        public Recipe recipe { get; set; }
        public void Print()
        {
            Console.Write("Doctor: ");
            Console.WriteLine($"{doctor.Id} {doctor.Firstname} Recipe - {recipe.Name} {recipe.Description}");
        }
    }
}
