using System;

namespace ShootingRange.Server.Dto
{
    public class ContactDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public byte Gender { get; set; }
        public DateTime? Birth { get; set; }
        public string Techno { get; set; }
        public string Message { get; set; }
    }
}