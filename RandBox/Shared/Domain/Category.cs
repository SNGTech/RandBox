using System.ComponentModel.DataAnnotations;

namespace RandBox.Shared.Domain
{
	public class Category
	{
        [Key]
        public int CategoryID { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
        public string? BadgeColour { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}