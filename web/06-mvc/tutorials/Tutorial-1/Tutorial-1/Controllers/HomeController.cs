using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Model;
using Tutorial_1.Services;
using Tutorial_1.Services.Interfaces;

namespace Tutorial_1.Controllers
{

    public class HomeController : Controller
    {

        private readonly IContactService _contactService;

        private readonly IPositionService _PositionService;
        private readonly IFileService _FileService;

        public HomeController(IContactService contactService, IPositionService positionService, IFileService fileService)
        {
            _contactService = contactService;
            _PositionService = positionService;
            _FileService = fileService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contacts = _contactService.GetContacts();
            return View(contacts);
        }

        [HttpGet("CreateContact")]
        public IActionResult CreateContact()
        {
            var positions = _PositionService.GetPositions();

            ViewBag.positions = positions;

            return View();
        }

        [HttpPost("CreateContactPost")]
        public IActionResult CreateContactPost(string name,string phone, string position)
        {

            List<Position> allPositions = _PositionService.GetPositions().ToList();

            Position contactPosition = allPositions.SingleOrDefault(x => x.Name == position);

            var newContact = new Contact() { Name = name, Phone = phone, position =  contactPosition};

            _contactService.CreateContact(newContact);

            var contactList = _contactService.GetContacts();

            _FileService.SaveToFile(contactList);

            return View("Contact", contactList);
        }
    }
}
