using Microsoft.AspNetCore.Identity;

namespace ShootingRange.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser
    {   
        public ApplicationUser() : base () {}
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public long? FacebookId { get; set; }

        public string GoogleId { get; set; }
        public string PictureUrl { get; set; }

        // public override bool Equals(object obj)
        // {
        //     return obj is ApplicationUser user &&
        //            FirstName == user.FirstName &&
        //            LastName == user.LastName &&
        //            FacebookId == user.FacebookId &&
        //            GoogleId == user.GoogleId &&
        //            PictureUrl == user.PictureUrl;
        // }
    }
}