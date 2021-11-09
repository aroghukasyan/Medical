using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PatientRecipe : IPrint
    {
        public Patient Patient { get; set; }
        public Recipe Recipe { get; set; }

        public void Print()
        {
            Console.Write("Recipe: ");
            Console.WriteLine($"{Patient.Id} {Patient.Firstname} \n {Recipe.Name} {Recipe.Description}");
        }
        public void PrintDeep()
        {
            throw new NotImplementedException();
        }
    }
}
