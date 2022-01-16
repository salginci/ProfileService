using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProfileService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProfileService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatformUserController : Controller
    {
        private readonly ILogger<PlatformUserController> _logger;

        public  PlatformUserController(ILogger<PlatformUserController> logger)
        {
            _logger = logger;
        }


        [HttpGet("{id}")]
        public PlatformUser Get(string id)
        {
            return new PlatformUser { Fullname = "Ozgur SALGINCI", Id = "9090", Title = "Software Development Specialist" };


        }



    }
}
