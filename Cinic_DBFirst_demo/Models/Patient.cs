using System;
using System.Collections.Generic;

namespace Cinic_DBFirst_demo.Models
{
    public partial class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Diagnosis { get; set; }
        public int? DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
