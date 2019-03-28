using System.Collections.Generic;

namespace Cinic_DBFirst_demo.DAL
{
    public interface IPatientRepository : IRepository<Patient>
    {
        IEnumerable<Patient> GetOlderPatient(int age);
    }
}
