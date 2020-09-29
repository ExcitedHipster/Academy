using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IDataRepository _dataRepository;

        public UserController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _dataRepository.GetUsers();
        }

        [HttpGet]
        [Route("{id}")]
        public User Get([FromRoute]int id)
        {
            var query = HttpContext.Request.Query.FirstOrDefault();
            return _dataRepository.GetUser(id);
        }

        
        [HttpPost]
        public User Post([FromForm] User user)
        {
           var result = _dataRepository.Add(user);
            return result;
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _dataRepository.Delete(id);

            if (result) return Ok();

            else return BadRequest();
        }
    }
}