using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShootingRange.Infrastructure.Helpers;
using ShootingRange.Core.DomainModels;

namespace ShootingRange.Server.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        public static ISet<Contact> contacts = new HashSet<Contact>()
        {
            Contact.Create(1, "User1", "user1@email.com", 1, DateTime.Now, "c#", "Wiadomość 1"),
            Contact.Create(2, "User2", "user2@email.com", 2, DateTime.Now, "c#", "Wiadomość 2"),
            Contact.Create(3, "User3", "user3@email.com", 1, DateTime.Now, "c#", "Wiadomość 3"),
            Contact.Create(4, "User4", "user4@email.com", 3, DateTime.Now, "c#", "Wiadomość 4"),
        };
        private readonly ILogger<ContactController> _logger;
        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResponse> GetAll()
        {
            ApiResponse response = new ApiResponse(200, "GetAll()", contacts);
            return response;
        }

        [HttpGet("GetById")]
        public async Task<ApiResponse> GetById(int id)
        {
            var item = contacts.SingleOrDefault(i => i.Id == id);
            ApiResponse response = new ApiResponse(200, $"GetById{id}", item);
            return response;
        }

        [HttpPost("Create")]
        public async Task<ApiResponse> Post(Contact contact)
        {

            ApiResponse apiResponse = new ApiResponse(200, "Create", contact);
            return apiResponse;
        }

        [HttpPut("Update")]
        public async Task<ApiResponse> Put(int id, Contact contact)
        {
            ApiResponse apiResponse = new ApiResponse(200, "Update", contact);
            return apiResponse;
        }

        [HttpDelete("Delete")]
        public async Task<ApiResponse> Delete(int id)
        {
            var item = contacts.SingleOrDefault(i => i.Id == id);
            if(item !=null)
            {
                contacts.Remove(item);
            }
            
            ApiResponse response = new ApiResponse(200, $"Delete({id})", contacts);
            return response;
        }




        [HttpGet]
        public async Task<string> GetString()
        {
            return "witaj";
        }
    }
}