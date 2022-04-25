using System.ComponentModel.DataAnnotations;

namespace Library_Registiration.Models
{
    public class Book
    {
        [Key]
        public int Book_id { get; set; }
        [Required(ErrorMessage ="Please enter book name")]
        public string Book_name { get; set; }

        [Required(ErrorMessage = "Please enter author name")]
        public string Book_author { get; set; }

        [Required(ErrorMessage ="Please enter publisher name")]
        public string Book_publisher { get; set; }

        [Required(ErrorMessage = "Please enter subject")]
        public string Book_subject { get; set; }



    }
}
