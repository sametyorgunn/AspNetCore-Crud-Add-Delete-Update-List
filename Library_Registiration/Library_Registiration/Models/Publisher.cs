using System.ComponentModel.DataAnnotations;

namespace Library_Registiration.Models
{
    public class Publisher
    {
        [Key]
        public int Publisher_id { get; set; }

        [Required(ErrorMessage = "Please enter publisher name")]
        public string Publisher_name { get; set; }

        [Required(ErrorMessage = "Please enter information about publisher")]
        public string Publisher_About { get; set; }
    }
}
