
namespace CameraBazaar.Web.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        //use flags
        //public User()
        //{
        //    LightMetering some = LightMetering.Spot | LightMetering.Evaluative;
        //}

        public List<Camera> Cameras { get; set; } = new List<Camera>();
    }
}
