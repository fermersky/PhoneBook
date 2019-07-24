using DataEntities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Server.Controllers
{
    [Route("api/{constroller}")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Contacts>> Get()
        {
            using (var db = new PhonebookDBContext())
            {
                return db.Contacts.ToList();
            }
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            using (var db = new PhonebookDBContext())
            {
                var con = db.Contacts.FirstOrDefault(c => c.Id == id);

                if (con != null)
                    return new ObjectResult(con);
                return NotFound("Not found contact with a same Id");
            }
        }

        [HttpPost]
        public ActionResult Post([FromQuery] Contacts contact)
        {
            using (var db = new PhonebookDBContext())
            {
                db.Contacts.Add(contact);
                db.SaveChanges();

                return new ObjectResult(contact);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromQuery] Contacts contact)
        {
            using (var db = new PhonebookDBContext())
            {
                var con = db.Contacts.FirstOrDefault(c => c.Id == id);

                if (con != null)
                {
                    con.Name = contact.Name;
                    con.Phone = contact.Phone;
                    con.UserId = contact.UserId;

                    db.SaveChanges();

                    return new ObjectResult(contact);
                }
                return NotFound("Not found contact with a same Id");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            using (var db = new PhonebookDBContext())
            {
                var con = db.Contacts.FirstOrDefault(c => c.Id == id);

                if (con != null)
                {
                    db.Contacts.Remove(con);
                    db.SaveChanges();

                    return Ok();
                }

                return NotFound("Not found contact with a same Id");
            }
        }
    }
}
