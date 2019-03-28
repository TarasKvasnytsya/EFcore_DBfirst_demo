using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Doctor> GetDoctorWithPatients (int id)
        {
            return ClinicContext.Doctor.Where(x => x.Id == id).ToArray().Select(x =>
            {
                x.Patient = ClinicContext.Patient.Where(p => p.DoctorId == id).ToList<Patient>();
                return x;
            });

        }

        public ClinicContext ClinicContext { get { return Context as ClinicContext; } }
    }
}
