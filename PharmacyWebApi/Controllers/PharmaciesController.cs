using PharmacyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PharmacyWebApi.Controllers
{
    public class PharmaciesController : ApiController
    {
        private MyDbContext _context;

        public PharmaciesController()
        {
            _context = new MyDbContext();
        }

        [HttpGet]
        [Route("pharmacies/all")]
        public IHttpActionResult GetAllPharmacies()
        {
            var pharmacies = _context.Pharmacies.ToList();

            return Ok(pharmacies);
        }

        [HttpPost]
        [Route("pharmacies/add")]
        public IHttpActionResult Add(Pharmacy pharmacy)
        {
            try
            {
                _context.Pharmacies.Add(pharmacy);
                _context.SaveChanges();

                return Ok();
            }
            catch(DbEntityValidationException e)
            {
                MyLog log = new MyLog()
                {
                    Log = e.StackTrace
                };

                _context.Logs.Add(log);
                _context.SaveChanges();

                return BadRequest();
            }
        }
    }
}
