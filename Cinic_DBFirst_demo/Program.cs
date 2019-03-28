using Cinic_DBFirst_demo.DAL;
using System;

namespace Cinic_DBFirst_demo
{
    public class Program
    {
        static void Main()
        {
            var operation = new Operations(new UnitOfWork(new ClinicContext()));

            while (true)
            {
                operation.ShowOperations();
                string numberOfOperation = Console.ReadLine();
                bool success = Int32.TryParse(numberOfOperation, out int number);
                if (!success && numberOfOperation[0]!='x')
                {
                    Console.WriteLine("You enter an invalid number of operation, please enter correct number!");
                    Console.ReadKey();
                    continue;
                }
                if (numberOfOperation[0]=='x') 
                {
                    break;
                }

                switch (number)
                {
                    case 1:
                        {
                            operation.CreateNewDoctor();
                            break;
                        }
                    case 2:
                        {
                            operation.CreateNewPatient();
                            break;
                        }
                    case 3:
                        {
                            operation.RemoveDoctor();
                            break;
                        }
                    case 4:
                        {
                            operation.RemovePatient();
                            break;
                        }
                    case 5:
                        {
                            operation.GetDoctor();
                            break;
                        }
                    case 6:
                        {
                            operation.GetPatient();
                            break;
                        }
                    case 7:
                        {
                            operation.GeAllDoctors();
                            break;
                        }
                    case 8:
                        {
                            operation.GetAllPatients();
                            break;
                        }
                    case 9:
                        {
                            operation.GetDoctorsForSpecialization();
                            break;
                        }
                    case 10:
                        {
                            operation.GetOlderPatient();
                            break;
                        }
                    case 11:
                        {
                            operation.GetDoctorWithPatients();
                            break;
                        }
                    case 12:
                        {
                            operation.UpdateDoctor();
                            break;
                        }
                    case 13:
                        {
                            operation.UpdateDoctor();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You enter an invalid number of operation, please enter correct number!");
                            Console.ReadKey();
                            continue;                            
                        }                       
                }

                Console.ReadKey();
                operation.ShowOperations();
            }
            Console.WriteLine("You quit a program, thanks!");
            Console.ReadKey();
        }

        
    }
}
