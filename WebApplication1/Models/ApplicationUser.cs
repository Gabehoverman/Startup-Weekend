using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {


        public Profile profile { get; set; }

       

        public static void SetProfileAsync(ApplicationUser user , Profile userprofile)
        {

            user.profile = userprofile;
            
        }

        public static void RemoveProfileAsync(ApplicationUser user)
        {
            user.profile = null;

        }

        

    }
}
