using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class Patients
    {
        [Key]
        [StringLength(10)]
        public string SSN { get; set; }

        [StringLength(128)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Measurements> Measurements { get; set; }
    }
}