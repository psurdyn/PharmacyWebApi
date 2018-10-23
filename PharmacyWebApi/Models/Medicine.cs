using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmacyWebApi.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string MedicineNumber { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}