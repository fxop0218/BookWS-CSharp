using System;
using System.ComponentModel;
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
        [DisplayName("Display Order")] // To change the reference name of the column
        [Range(1,100,ErrorMessage="Display order must be between 1 an 100 caracters")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDataTime { get; set; } = DateTime.Now; 

    }
}
