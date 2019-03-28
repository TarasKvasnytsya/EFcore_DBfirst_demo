using Cinic_DBFirst_demo.DAL;
using System;

namespace Cinic_DBFirst_demo
{
    public class Operations
    {
        UnitOfWork unitOfWork;

        public Operations(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void CreateNewDoctor()
        {
            Console.Clear();
            Console.WriteLine("Please enter information about doctor: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine().Trim();
            Console.WriteLine("Specialization: ");
            string specialization = Console.ReadLine().Trim();

            var doctorItem = new Doctor()
            {
                Name = name,
                Surname = surname,
                Specialization = specialization
            };

            unitOfWork.Doctors.Add(doctorItem);
            unitOfWork.Save();            

            Console.WriteLine("Operation completed");
        }

        public void CreateNewPatient()
        {
            Console.Clear();
            Console.WriteLine("Please enter information about patient: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("Age: ");
            string age= Console.ReadLine().Trim();
            bool success = Int32.TryParse(age, out int number_age);
            if (!success)
            {
                Console.WriteLine("You enter invalid age");
                return;
            }
            Console.WriteLine("Diagnosis: ");
            string diagnosis = Console.ReadLine().Trim();
            Console.WriteLine("Doctor ID: ");
            string doctorId = Console.ReadLine().Trim();
            bool parsing = Int32.TryParse(doctorId, out int number_id);

            var patientItem = new Patient()
            {
                Name = name,
                Age = number_age,
                Diagnosis = diagnosis,
                DoctorId = number_id
            };

            unitOfWork.Patients.Add(patientItem);
            unitOfWork.Save();

            Console.WriteLine("Operation completed");
        }

        public void RemoveDoctor()
        {
            Console.Clear();
            Console.WriteLine("Please enter id doctor: ");
            string numberId = Console.ReadLine().Trim();
            bool success = Int32.TryParse(numberId, out int id);
            if (!success)
            {
                Console.WriteLine("You enter invalid id");
                return;
            }

            var doctorItem = unitOfWork.Doctors.Get(id);
            unitOfWork.Doctors.Remove(doctorItem);
            unitOfWork.Save();

            Console.WriteLine("Operation completed");
        }
        public void RemovePatient()
        {
            Console.Clear();
            Console.WriteLine("Please enter id patient: ");
            string numberId = Console.ReadLine().Trim();
            bool success = Int32.TryParse(numberId, out int id);
            if (!success)
            {
                Console.WriteLine("You enter invalid id");
                return;
            }

            var patientItem = unitOfWork.Patients.Get(id);
            unitOfWork.Patients.Remove(patientItem);
            unitOfWork.Save();

            Console.WriteLine("Operation completed");
        }
        public void GetDoctor()
        {
            Console.Clear();
            Console.WriteLine("Please enter id doctor: ");
            string numberId = Console.ReadLine().Trim();
            bool success = Int32.TryParse(numberId, out int id);
            if (!success)
            {
                Console.WriteLine("You enter invalid id");
                return;
            }

            var doctorItem = unitOfWork.Doctors.Get(id);            

            Console.WriteLine(doctorItem);
        }
        public void GetPatient()
        {
            Console.Clear();
            Console.WriteLine("Please enter id patient: ");
            string numberId = Console.ReadLine().Trim();
            bool success = Int32.TryParse(numberId, out int id);
            if (!success)
            {
                Console.WriteLine("You enter invalid id");
                return;
            }

            var patientItem = unitOfWork.Patients.Get(id);                

            Console.WriteLine(patientItem);
            
        }
        public void GeAllDoctors()
        {
            Console.Clear();
            var doctorItems = unitOfWork.Doctors.GetAll();
            foreach (var item in doctorItems)
            {
                Console.WriteLine(item);
            }
        }
        public void GetAllPatients()
        {
            Console.Clear();

            var patientItem = unitOfWork.Patients.GetAll();
            foreach (var item in patientItem)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowOperations()
        {
            Console.Clear();
            Console.WriteLine("Please select one operation from list:");
            Console.WriteLine("1. Create New Doctor");
            Console.WriteLine("2. Create New Patient");
            Console.WriteLine("3. Remove Doctor");
            Console.WriteLine("4. Remove Patient");
            Console.WriteLine("5. Get Doctor");
            Console.WriteLine("6. Get Patient");
            Console.WriteLine("7. Show all Doctor");
            Console.WriteLine("8. Show all Patient");
            Console.WriteLine("Enter 'q' to quit the program");
            Console.WriteLine("Please enter number of operation: ");
        }

    }
}
