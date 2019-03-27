using Cinic_DBFirst_demo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinic_DBFirst_demo.DAL
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        IEnumerable<Doctor> GetDoctorsForSpecialization(string specialization);
    }
}
