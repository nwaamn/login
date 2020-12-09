﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebApplication1User class
    public class WebApplication1User : IdentityUser
    {
        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string FistName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
    }
}
