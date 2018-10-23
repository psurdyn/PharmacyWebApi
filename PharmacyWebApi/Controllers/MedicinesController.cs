using PharmacyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PharmacyWebApi.Controllers
{
    public class MedicinesController : ApiController
    {
        private MyDbContext _context;

        public MedicinesController()
        {
            _context = new MyDbContext();
        }

        [HttpGet]
        [Route("medicines/all")]
        public IHttpActionResult GetAllMedicines()
        {
            var medicines = _context.Medicines.ToList();

            return Ok(medicines);
        }

        [HttpPost]
        [Route("medicines/add")]
        public IHttpActionResult Add(Medicine medicine)
        {
            _context.Medicines.Add(medicine);
            _context.SaveChanges();

            return Ok();
        }


        [HttpGet]
        [Route("medicines/get/{medicineCode}")]
        public IHttpActionResult GetMedicine(string medicineCode)
        {
            var medicine = _context.Medicines.FirstOrDefault(x => x.MedicineNumber == medicineCode);

            if (medicine == null)
                return NotFound();

            return Ok(medicine);
        }

    }
}
