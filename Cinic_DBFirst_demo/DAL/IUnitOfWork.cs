using System;
using System.Collections.Generic;
using System.Text;

namespace Cinic_DBFirst_demo.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IDoctorRepository Doctors { get; }

        int Save();
    }
}
