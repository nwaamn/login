using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestLogin01.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Customer class
    public class Ctm : IdentityUser
    {
        [PersonalData]
        [Column(TypeName="nverchar(100)")]
        public string Name { get; set; }
        
        [PersonalData]
        [Column(TypeName = "nverchar(100)")]
        public string LastName { get; set; }
    }
}
