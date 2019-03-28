namespace Cinic_DBFirst_demo.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicContext _context;

        public UnitOfWork(ClinicContext context)
        {
            _context = context;
            Doctors = new DoctorRepository(_context);
            Patients = new PatientRepository(_context);
            
        }

        public IDoctorRepository Doctors { get; private set; }
        public IPatientRepository Patients { get; private set; }


        public int Save()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
