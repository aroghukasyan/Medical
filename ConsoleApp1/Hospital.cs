using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Hospital : IPrintable
    {
        public List<Doctor> Doctors;
        public List<Patient> Patients;
        public List<DoctorRecipe> DoctorRecipes;
        public List<PatientRecipe> PatientRecipes;

        public Hospital()
        {
            this.Doctors = new List<Doctor>();
            this.Patients = new List<Patient>();
            this.DoctorRecipes = new List<DoctorRecipe>();
            this.PatientRecipes = new List<PatientRecipe>();
        }

        public void RegisterDoctor(Doctor doctor)
        {
            if (doctor is null)
            {
                throw new NullReferenceException("Register doctor: doctor is null");
            }
            else
            {
                Doctors.Add(doctor);
            }
        }
        public void RemoveDoctor(Doctor doctor)
        {
            if (doctor is null)
            {
                throw new NullReferenceException("Remove doctor: doctor is null");
            }
            else
            {
                Doctors.Remove(doctor);
            }
            
        }
        public void UpdateDoctor(Action<List<Doctor>> action)
        {
            action(Doctors);
        }
        public void RegisterPatient(Patient patient)
        {
            if (patient is null)
            {
                throw new NullReferenceException("Register patient: doctor is null");
            }
            else
            {
                Patients.Add(patient);
            } 
        }
        public void RemovePatient(Patient patient)
        {
            if (patient is null)
            {
                throw new NullReferenceException("Remove patient: doctor is null");
            }
            else
            {
                Patients.Remove(patient);
            }
            
        }
        public void UpdatePatient(Action<List<Patient>> action)
        {
            action(Patients);
        }
        public void AssignePatientToDoctor(Patient patient, Doctor doc)
        {
            if(patient is null)
            {
                throw new NullReferenceException("Assigne Patient To Doctor: patient is null.");
            }
            if (doc is null)
            {
                throw new NullReferenceException("Assigne Patient To Doctor: doctor is null.");
            }
            patient.TryAssigneDoctor(doc);
            doc.TryAssignePatient(patient);
        }

        public void Print()
        {
            Console.WriteLine("Hospital Doctors...");
            Console.WriteLine();
            foreach (var item in Doctors)
            {
                Console.WriteLine($"{item.Id}  | {item.Firstname} {item.Lastname} {item.Age}");
            }
            Console.WriteLine();
            Console.WriteLine("Hospital Patients...");
            Console.WriteLine();
            foreach (var item in Patients)
            {
                Console.WriteLine($"{item.Id}  | {item.Firstname} {item.Lastname} {item.Age}");
            }            
        }

        public void PrintDeep()
        {
            throw new NotImplementedException();
        }
    }
}
