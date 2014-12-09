using System.ComponentModel.DataAnnotations;

namespace VolunteerApi.Models
{
    public class Conusmer
    {
        [Required]
        public string consumerKey { get; set; }
        
        [Required]
        public string consumerSecret { get; set; }
    }
}