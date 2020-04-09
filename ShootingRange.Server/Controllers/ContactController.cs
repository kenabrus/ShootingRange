using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShootingRange.Infrastructure.Helpers;
using ShootingRange.Core.DomainModels;
using ShootingRange.Server.Data;
using Microsoft.EntityFrameworkCore;
using ShootingRange.Server.Dto;

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
        private readonly ApplicationDbContext _context;
        public ContactController(ILogger<ContactController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResponse> GetAll()
        {
            var items = await _context.Contacts.ToListAsync();
            ApiResponse response = new ApiResponse(200, "GetAll()", items);
            return response;
        }

        [HttpGet("GetById")]
        public async Task<ApiResponse> GetById(int id)
        {
            var item = _context.Contacts.SingleOrDefault(i => i.Id == id);
            ApiResponse response = new ApiResponse(200, $"GetById{id}", item);
            return response;
        }

        [HttpPost("Create")]
        public async Task<ApiResponse> Post(ContactDto dto)
        {
            ApiResponse apiResponse = null;
            if(dto != null)
            {
                Contact item = Contact.Create2(dto.Name, dto.Email, dto.Gender, dto.Birth, dto.Techno, dto.Message);
                try{
                   await _context.Contacts.AddAsync(item); 
                   _context.SaveChanges();
                   apiResponse = new ApiResponse(200, "Create", item);
                }
                catch(Exception e){
                   apiResponse = new ApiResponse(500, "Create", e); 
                }
                
            }
            return apiResponse;
            
        }

        [HttpPut("Update")]
        public async Task<ApiResponse> Put(int id, ContactDto dto)
        {
            ApiResponse apiResponse = null;        
            Contact contact = _context.Contacts.FirstOrDefault(i => i.Id == id);
            if(contact != null)
            {
                contact.Name = dto.Name;
                contact.Email =  dto.Email;
                contact.Gender = dto.Gender;
                contact.Birth = dto.Birth; 
                contact.Techno = dto.Techno;
                contact.Message = dto.Message;
            }
            try{
                _context.Contacts.Update(contact);
                await _context.SaveChangesAsync();
                apiResponse = new ApiResponse(200, "Updated", contact);
            }catch(Exception e){
                apiResponse = new ApiResponse(500, "Not Updated", e.Message.FirstOrDefault());
            }
            return apiResponse;
        }

        [HttpDelete("Delete")]
        public async Task<ApiResponse> Delete(int id)
        {
            ApiResponse apiResponse = null;
            var item = _context.Contacts.SingleOrDefault(i => i.Id == id);
            if(item !=null)
            {
                try{
                  _context.Contacts.Remove(item);
                  await _context.SaveChangesAsync();
                  apiResponse = new ApiResponse(200, "Deleted", item);
                }catch(Exception e){
                  apiResponse = new ApiResponse(500, "Error", e.Message.FirstOrDefault());
                }
            }
            else
            {
                apiResponse = new ApiResponse(204, $"No item with id = {id} in DB", null);
            }
            return apiResponse;
        }
    }
}