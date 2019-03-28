using System.Collections.Generic;
using System.Linq;

namespace Cinic_DBFirst_demo.DAL
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(ClinicContext context)
            :base(context)
        {

        }
        public IEnumerable<Patient> GetOlderPatient(int age)
        {
            return ClinicContext.Patient.Where<Patient>(p => p.Age > age).ToList<Patient>();
        }

        public ClinicContext ClinicContext { get { return Context as ClinicContext; } }
    }
}
