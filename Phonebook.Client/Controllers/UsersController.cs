using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Phonebook.Client.Controllers
{
    [Route("")]
    [Route("Users")]
    public class UsersController : Controller
    {
        [Route("")]
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}