﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_4.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsDeactive { get; set; }
        public string Adress { get; set; }
        [NotMapped]
        public string Image { get; set; }
        public ProfilePhoto ProfilePhoto { get; set; }
        [NotMapped]
        [Required,DataType(DataType.Password)]
        public string NewPassword { get; set; }
        public Restaurant? Restaurant { get; set; }
        public int? RestaurantId { get; set; }

    }
}
