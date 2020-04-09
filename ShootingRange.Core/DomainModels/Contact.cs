using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShootingRange.Core.DomainModels
{
    public class Contact
    {
        //[JsonProperty(PropertyName="id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte Gender { get; set; }
        public DateTime? Birth { get; set; }
        public string Techno { get; set; }
        public string Message { get; set; }

        public Contact(){}

        private Contact(int id, string name, string email, byte gender, DateTime? birth, string techno, string message)
        {
            Id = id;
            Name = name;
            Email = email;
            Gender = gender;
            Birth = birth;
            Techno = techno;
            Message = message;
        }

        private Contact(string name, string email, byte gender, DateTime? birth, string techno, string message)
        {
            Name = name;
            Email = email;
            Gender = gender;
            Birth = birth;
            Techno = techno;
            Message = message;
        }

        public void SetName(string name) 
        {
            if (string.IsNullOrWhiteSpace(name)) 
            {
                throw new Exception($"Name can not by empty");
            }
            if (Name == name) 
            {
                return;
            }

            Name = name;
        }

        public static Contact Create(int id, string name, string email, byte gender, DateTime? birth, string techno, string message)
        {
            return new Contact(id, name, email, gender, birth, techno, message);
        }
        public static Contact Create2(string name, string email, byte gender, DateTime? birth, string techno, string message)
        {
            return new Contact(name, email, gender, birth, techno, message);
        }
    }
}