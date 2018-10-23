using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmacyWebApi.Models
{
    public class Pharmacy
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int DepartmentNumber { get; set; }
        public IEnumerable<Medicine> AvaiableMedicines { get; set; }
    }
}