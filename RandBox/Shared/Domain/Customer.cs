using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandBox.Shared.Domain
{
	public class Customer
	{
        [Key]
        public int CustID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? UnitNo { get; set; }
        public string? PostalCode { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}
