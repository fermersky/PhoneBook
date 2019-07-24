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
        // GET api/contacts
        [HttpGet]
        public ActionResult<List<Contacts>> Get()
        {
            using (var db = new PhonebookDBContext())
            {
                return db.Contacts.ToList();
            }
        }

        // GET api/contacts/2
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

        // POST api/contacts
        [HttpPost]
        public ActionResult Post([FromBody] Contacts contact)
        {
            using (var db = new PhonebookDBContext())
            {
                db.Contacts.Add(contact);
                db.SaveChanges();

                return new ObjectResult(contact);
            }
        }

        // PUT api/contacts/2
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Contacts contact)
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

        // DELETE api/contacts/2
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
