using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Repository;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            var users = _userRepository.GetUsers();
            return new OkObjectResult(users);
        }

        // GET: api/User/getuserbyid/{id}
        [HttpGet("/api/user/getuserbyid/{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);
            return new OkObjectResult(user);
        }
    }
}
