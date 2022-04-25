using System.ComponentModel.DataAnnotations;

namespace Library_Registiration.Models
{
    public class Author
    {
        [Key]
        public int Author_id { get; set; }

        [Required(ErrorMessage = "Please enter author name")]
        public string Author_name { get; set; }

        [Required(ErrorMessage = "Please enter information about author")]
        public string Author_about { get; set; }
    }
}
