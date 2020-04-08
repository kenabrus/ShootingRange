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
    }
}