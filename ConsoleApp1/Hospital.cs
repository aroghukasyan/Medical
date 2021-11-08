using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Hospital
    {
        public static List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public static List<Patient> Patients { get; set; } = new List<Patient>();
        public static List<DoctorRecipe> DoctorRecipes { get; set; } = new List<DoctorRecipe>();
        public static List<PatientRecipe> PatientRecipes { get; set; } = new List<PatientRecipe>();

        public void RegisterDoctor(Doctor doctor)
        {
            if (doctor is null)
            {
                Console.WriteLine("doctor is null: Register");
            }
            else
            {
                Doctors.Add(doctor);
            }
        }
        public void RemoveDoctor(Doctor doctor)
        {
            Doctors.Remove(doctor);
        }
        public void UpdateDoctor(Action<List<Doctor>> action)
        {
            action(Doctors);
        }
        public void RegisterPatient(Patient patient)
        {
            Patients.Add(patient);
        }
        public void RemovePatient(Patient patient)
        {
            Patients.Remove(patient);
        }
        public void UpdatePatient(Action<List<Patient>> action)
        {
            action(Patients);
        }
        public void AssignePatientToDoctor(Patient patient, Doctor doc)
        {
            if(patient is null)
            {
                Console.WriteLine("Class Hospital\nMetoth AssignPatientToDoctor\n Patient is null\n");
            }
            if (doc is null)
            {
                Console.WriteLine("Class Hospital\nMetoth AssignPatientToDoctor\n Doctor is null\n");
            }
            Doctors.Where(s => s.Id == doc.Id)
                .FirstOrDefault().Patients.Add(patient);
            
            if(Patients.Where(p => p.Id == patient.Id).Any())
            {
                Patients.Where(s => s.Id == patient.Id)
                .FirstOrDefault().Doctors.Add(doc);
            }
            else
            {
                Patients.Add(patient);
                Patients.Where(s => s.Id == patient.Id)
                .FirstOrDefault().Doctors.Add(doc);
            }
        }
    }
}
