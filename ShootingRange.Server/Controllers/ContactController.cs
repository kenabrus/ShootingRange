using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShootingRange.Infrastructure.Helpers;

namespace ShootingRange.Server.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;
        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        public async Task<string> GetString()
        {
            return "witaj";
        }
    }
}