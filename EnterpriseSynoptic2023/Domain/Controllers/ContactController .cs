using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web;
using System.Web.Mvc;


namespace Domain.Models
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var contacts = _contactService.GetContacts();
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact contact, HttpPostedFileBase picture)
        {
            if (ModelState.IsValid)
            {
                if (picture != null && picture.ContentLength > 0)
                {
                    using (var reader = new System.IO.BinaryReader(picture.InputStream))
                    {
                        contact.Picture = reader.ReadBytes(picture.ContentLength);
                    }
                }
                service.AddContact(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }
    }
}


