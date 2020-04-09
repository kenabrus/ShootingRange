using System;

namespace ShootingRange.Core.DomainModels
{
    public class Contact
    {
        //[JsonProperty(PropertyName="id")]
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte Gender { get; set; }
        public DateTime? Birth { get; set; }
        public string Techno { get; set; }
        public string Message { get; set; }

        public Contact(){}

        private Contact(int id, string name, string email, byte gender, DateTime birth, string techno, string message)
        {
            Id = id;
            Name = name;
            Email = email;
            Gender = gender;
            Birth = birth;
            Techno = techno;
            Message = message;
        }

        public static Contact Create(int id, string name, string email, byte gender, DateTime birth, string techno, string message)
        {
            return new Contact(id, name, email, gender, birth, techno, message);
        }
    }
}