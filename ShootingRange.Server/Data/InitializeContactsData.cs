using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using ShootingRange.Core.DomainModels;

namespace ShootingRange.Server.Data
{
    public static class InitializeContactsData
    {
        public static async Task InitializeAsync(IServiceProvider service)
        {
            using (var serviceScope = service.CreateScope())
            {
                var scopeServiceProvider = serviceScope.ServiceProvider;
                var context = scopeServiceProvider.GetService<ApplicationDbContext>();
                //db.Database.Migrate();  // Tworzy bazę jeśli baza nie istnieje
                await InsertTestData(context);
            }
        }

        private static async Task InsertTestData(ApplicationDbContext context)
        {
            if(context.Contacts.Any())
            {
                Console.WriteLine("InitializeContactsData - elements exists");
                return;
            }

            var contacts = new List<Contact>()
            {
                Contact.Create2("User1", "user1@email.com", 1, DateTime.Now, "c#", "Wiadomość 1"),
                Contact.Create2("User2", "user2@email.com", 2, DateTime.Now, "c#", "Wiadomość 2"),
                Contact.Create2("User3", "user3@email.com", 1, DateTime.Now, "c#", "Wiadomość 3"),
                Contact.Create2("User4", "user4@email.com", 3, DateTime.Now, "c#", "Wiadomość 4"),
                Contact.Create2("User5", "user5@email.com", 5, DateTime.Now, "c#", "Wiadomość 1"),
                Contact.Create2("User6", "user6@email.com", 6, DateTime.Now, "c#", "Wiadomość 2"),
                Contact.Create2("User7", "user7@email.com", 7, DateTime.Now, "c#", "Wiadomość 3"),
                Contact.Create2("User8", "user8@email.com", 7, DateTime.Now, "c#", "Wiadomość 4")
            };

            foreach(Contact c in contacts)
            {
               context.Contacts.Add(c);
            }
            Console.WriteLine($"InitializeContactsData - {contacts.Count()} contacts added to db");
            await context.SaveChangesAsync();
        }
    }
}