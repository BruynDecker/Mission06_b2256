using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_b2256.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int FilmID { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public int CategoryID { get; set; }

        public category Category { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1800, 2100, ErrorMessage = "Year must be between 1800 and 2100.")]
        public ushort Year { get; set; }

        [Required(ErrorMessage = "Please enter a director.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please select a rating.")]
        public string Rating { get; set; }

        [Display(Name = "Edited?")]
        public bool Edited { get; set; }

        [Display(Name = "Lent To")]
        public string LentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes must be 25 characters or less.")]
        public string Notes { get; set; }


    }
}
