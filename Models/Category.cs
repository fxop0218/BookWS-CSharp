using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BookWeb.Models
{
    public class Category
    {
        [Key] // Primary key
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDataTime { get; set; } = DateTime.Now; 

    }
}
