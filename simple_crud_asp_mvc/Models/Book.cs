using System;
using System.ComponentModel.DataAnnotations;

namespace simple_crud_asp_mvc.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The title is required")]
        [StringLength(50, ErrorMessage = "The {0} must be at between {2} and {1} characters", MinimumLength = 3)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The description is required")]
        [StringLength(50, ErrorMessage = "The {0} must be at between {2} and {1} characters", MinimumLength = 3)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "PublicationDate")]
        public DateTime PublicationDate { get; set; }

        [Required(ErrorMessage = "The author is required")]
        public string Author { get; set; }

        [Required(ErrorMessage = "The price is required")]
        public int Price { get; set; }
    }
}
