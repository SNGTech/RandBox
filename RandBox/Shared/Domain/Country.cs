using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandBox.Shared.Domain
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? BadgeColour { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}
