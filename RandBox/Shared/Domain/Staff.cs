﻿using System.ComponentModel.DataAnnotations;

namespace RandBox.Shared.Domain
{
	public class Staff
	{
        [Key]
        public int StaffID { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? ContactNumber { get; set; }

        
    }
}