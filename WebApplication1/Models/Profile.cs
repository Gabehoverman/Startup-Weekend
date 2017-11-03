using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Profile
    {


        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }


        
        public void mapprofile(Profile profile)
        {

            profile.Id = Id;
            profile.firstName = firstName;
            profile.lastName = lastName;
            profile.age = age;

        }

    }

    
}
