using System.Collections.Generic;
using System.Linq;

namespace Cinic_DBFirst_demo.DAL
{
    public class DoctorRepository : Repository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ClinicContext context)
            :base(context)
        {

        }

        public IEnumerable<Doctor> GetDoctorsForSpecialization(string specialization)
        {
            return ClinicContext.Doctor.Where<Doctor>(p => p.Specialization == specialization).ToList<Doctor>();
        }

        public ClinicContext ClinicContext { get { return Context as ClinicContext; } }
    }
}
