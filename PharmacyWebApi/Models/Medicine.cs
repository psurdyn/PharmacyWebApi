using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmacyWebApi.Models
{
    public class Medicine
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string MedicineNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}