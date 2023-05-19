﻿using System.ComponentModel.DataAnnotations;

namespace GymUsers.Models
{
    public class User
    {

        [Key] public int Id { get; set; }

        [Required] public string Name { get; set; }
        [Required] public string Surname { get; set; }
        [Required] public string Email { get; set; }

        
    }
}
