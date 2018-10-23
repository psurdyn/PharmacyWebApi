using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmacyWebApi.Models
{
    public class Pharmacy
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        public int DepartmentNumber { get; set; }

        public IEnumerable<Medicine> AvaiableMedicines { get; set; }
    }
}