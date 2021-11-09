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
                Doctor doc1 = new Doctor("Vaxarshak", "Sedrakyan", 32) { Speciality = MedicalSpecialties.Urology };
                Doctor doc2 = new Doctor("Karmen", "Berberyan", 56) { Speciality = MedicalSpecialties.PreventiveMedicine };
                Doctor doc3 = new Doctor("Anna", "Grigoryan", 29) { Speciality = MedicalSpecialties.Pathology };
                Doctor doc4 = new Doctor("Simon", "Vladimirovich", 41) { Speciality = MedicalSpecialties.Surgery };
                Doctor doc5 = new Doctor("Vahan", "Karapetyan", 37) { Speciality = MedicalSpecialties.RadiationOncology };

                Patient pat1 = new Patient("Janna", "Soxomonyan", 41) { Gender = false, };
                Patient pat2 = new Patient("Klara", "Svajyan", 27) { Gender = false, };
                Patient pat3 = new Patient("Norik", "Minasyan", 23) { Gender = true, };
                Patient pat4 = new Patient("Armen", "Simonyan", 47) { Gender = true, };
                Patient pat5 = new Patient("Narek", "Hneyan", 14) { Gender = true, };
                Patient pat6 = new Patient("Avetik", "Avanyan", 39) { Gender = true, };
                Patient pat7 = new Patient("Lianna", "Azoyan", 48) { Gender = false, };
                Patient pat8 = new Patient("Narine", "Karapetyan", 18) { Gender = false, };
                Patient pat9 = new Patient("Karen", "Abgaryan", 23) { Gender = true, };
                Patient pat10 = new Patient("Tigran", "Bagratuni", 23) { Gender = true, };
                Patient pat11 = new Patient("Nazeli", "Hovhanisyan", 23) { Gender = false, };
                Patient pat12 = new Patient("Norik", "Minasyan", 23) { Gender = true, }; // repeat

                Hospital hospital = new Hospital();
                hospital.RegisterDoctor(doc1);
                hospital.RegisterDoctor(doc2);
                hospital.RegisterDoctor(doc3);
                hospital.RegisterDoctor(doc4);
                hospital.RegisterDoctor(doc5);

                hospital.RegisterPatient(pat1);
                hospital.RegisterPatient(pat2);
                hospital.RegisterPatient(pat3);
                hospital.RegisterPatient(pat4);
                hospital.RegisterPatient(pat5);
                hospital.RegisterPatient(pat6);
                hospital.RegisterPatient(pat7);
                hospital.RegisterPatient(pat8);
                hospital.RegisterPatient(pat9);
                hospital.RegisterPatient(pat10);

                doc1.TryAssignePatient(pat1);
                doc1.TryAssignePatient(pat2);
                doc1.TryAssignePatient(pat6);

                doc2.TryAssignePatient(pat1);
                doc2.TryAssignePatient(pat7);
                doc2.TryAssignePatient(pat8);
                doc2.TryAssignePatient(pat9);

                doc3.TryAssignePatient(pat4);
                doc3.TryAssignePatient(pat5);

                doc4.TryAssignePatient(pat10);
                doc4.TryAssignePatient(pat3);
                doc4.TryAssignePatient(pat8);
                doc4.TryAssignePatient(pat7);
                doc4.TryAssignePatient(pat7); // re

                doc5.TryAssignePatient(pat1);
                doc5.TryAssignePatient(pat2);
                doc5.TryAssignePatient(pat3);
                doc5.TryAssignePatient(pat4);
                doc5.TryAssignePatient(pat5);
                doc5.TryAssignePatient(pat6);
                doc5.TryAssignePatient(pat7);
                doc5.TryAssignePatient(pat8);
                doc5.TryAssignePatient(pat9);
                doc5.TryAssignePatient(pat10);
                doc5.TryAssignePatient(pat11);
                doc5.TryAssignePatient(pat12);

                hospital.AssignePatientToDoctor(pat1, doc1);
                var doctor = hospital.Doctors.Where(s => s.Id == doc1.Id).FirstOrDefault();
                var recipe1 = new Recipe() { Name = "analgin", Description = "one time on day" };
                doctor.AssigneRecipe(pat1, recipe1);
                doctor.AssigneRecipe(pat1, recipe1);
                doctor.AssigneRecipe(pat1, recipe1);
                doctor.AssigneRecipe(pat1, recipe1);
                doc1.AssigneRecipe(pat1, new Recipe() { Name = "analgin", Description = "once every day" });
                doc1.AssigneRecipe(pat1, new Recipe() { Name = "analgin", Description = "once every day" });
                doc1.AssigneRecipe(pat1, new Recipe() { Name = "analgin", Description = "once every day" });
                doc1.AssigneRecipe(pat1, new Recipe() { Name = "analgin", Description = "once every day" });
                doc1.AssigneRecipe(pat1, new Recipe() { Name = "analgin", Description = "once every day" });

                hospital.Print();
                Console.WriteLine();
                foreach (var item in hospital.Doctors)
                {
                    item.Print();
                }
                Console.WriteLine();
                foreach (var item in hospital.Patients)
                {
                    item.Print();
                }
                Console.WriteLine();
                foreach (var item in hospital.Doctors)
                {
                    item.PrintDeep();
                }
                Console.WriteLine();
                foreach (var item in hospital.Patients)
                {
                    item.PrintDeep();
                }


                //hospital.UpdateDoctor(s => s.Where(s => s?.Id == 2).FirstOrDefault().Firstname = "SSSS");
            }
            catch (Exception mesagge)
            {
                Console.WriteLine(mesagge);
            }
        }
    }
}
