using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3_Movie.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required(ErrorMessage ="Please enter Category field")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter Title field")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter Year field")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Please enter Director field")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please enter Rating field")]
        public string Rating { get; set; }

       //optional
        public bool Edited { get; set; }

      //optional
        public string LentTo { get; set; }

        [StringLength(25, ErrorMessage = "The Note must not exceed 25 characters")]
        public string Notes { get; set; }
    }
}
