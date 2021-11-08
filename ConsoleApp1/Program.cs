using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
namespace ConsoleApp1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Doctor doc1 = new Doctor("Vaxarshak", "Sedrakyan", 32) {Speciality = MedicalSpecialties.Urology};
                Doctor doc2 = new Doctor("Karmen", "Berberyan", 56) { Speciality = MedicalSpecialties.PreventiveMedicine };
                Doctor doc3 = new Doctor("Anna", "Grigoryan", 29) { Speciality = MedicalSpecialties.Pathology };
                Doctor doc4 = new Doctor("Simon", "Vladimirovich", 41) { Speciality = MedicalSpecialties.Surgery };
                Doctor doc5 = new Doctor("Vahan", "Karapetyan", 37) { Speciality = MedicalSpecialties.RadiationOncology };

                Patient pat1 = new Patient("Janna", "Soxomonyan", 41) { Gender = true, };
                Patient pat2 = new Patient("Klara", "Svajyan", 27) { Gender = true, };
                Patient pat3 = new Patient("Norik", "Minasyan", 23) { Gender = true, };

                Hospital hospital = new Hospital();
                hospital.RegisterDoctor(doc1);
                hospital.RegisterDoctor(doc2);
                hospital.RegisterDoctor(doc3);
                hospital.RegisterDoctor(doc4);
                hospital.RegisterDoctor(doc5);

                foreach (var item in Hospital.Doctors)
                {
                    Console.WriteLine(item.Firstname + " " + item.Lastname);
                }
                Console.WriteLine();

                //hospital.UpdateDoctor(s => s.Where(s => s?.Id == 2).FirstOrDefault().Firstname = "SSSS");
                //foreach (var item in Hospital.Doctors)
                //{
                //    Console.WriteLine(item.Firstname + " " + item.Lastname);
                //}

                hospital.AssignePatientToDoctor(pat1, Hospital.Doctors
                    .Where(d => d.Firstname == "Vaxarshak")
                    .FirstOrDefault());
                hospital.AssignePatientToDoctor(pat2, Hospital.Doctors
                    .Where(d => d.Firstname == "Vaxarshak")
                    .FirstOrDefault());
                var iter = Hospital.Doctors
                    .Where(d => d.Firstname == "Vaxarshak")
                    .FirstOrDefault();
                
                foreach (var i in iter.Patients)
                {
                        Console.WriteLine($"{i.Age} {i.Firstname} {i.Lastname}");
                } 
            }
            catch(Exception mesagge)
            {
                Console.WriteLine(mesagge);
            }
        }
    }
}
