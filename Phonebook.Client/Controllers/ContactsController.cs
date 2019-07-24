using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Phonebook.Client.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            return View(id);
        }

        public IActionResult Delete(int id)
        {
            return View(id);
        }
    }
}