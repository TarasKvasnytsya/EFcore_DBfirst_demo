using System;
using System.Collections.Generic;

namespace Cinic_DBFirst_demo
{
    public partial class Doctor
    {
        public Doctor()
        {
            Patient = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Specialization { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
