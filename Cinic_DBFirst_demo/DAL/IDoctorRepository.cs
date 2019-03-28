using System.Collections.Generic;

namespace Cinic_DBFirst_demo.DAL
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        IEnumerable<Doctor> GetDoctorsForSpecialization(string specialization);
    }
}
