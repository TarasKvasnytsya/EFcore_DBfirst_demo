using System;

namespace Cinic_DBFirst_demo.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IDoctorRepository Doctors { get; }
        IPatientRepository Patients { get; }

        int Save();
    }
}
