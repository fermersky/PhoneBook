using DataEntities.Model;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Server.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Server.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Users _user)
        {
            using (var db = new PhonebookDBContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Lgn == _user.Lgn);

                if (user != null)
                {
                    if (user.Pwd == MD5Converter.GetHashFromString(_user.Pwd))
                        return Ok(user.Id);
                    else
                        return Unauthorized("Invalid password");
                }

                return NotFound("User with login " + _user.Lgn + " does not exist");
            }
        }
    }
}
