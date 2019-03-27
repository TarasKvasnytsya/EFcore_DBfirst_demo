using Cinic_DBFirst_demo.DAL;
using Cinic_DBFirst_demo.Models;
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

        }

        public void RemoveDoctor()
        {

        }
        public void RemovePatient()
        {

        }
        public void GetDoctor()
        {

        }
        public void GetPatient()
        {

        }
        public void GeAllDoctors()
        {

        }
        public void GetAllPatients()
        {

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
