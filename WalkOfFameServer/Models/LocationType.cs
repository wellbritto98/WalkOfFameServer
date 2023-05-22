using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models
{
    public class LocationType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)] 
        public string Name { get; set; }
    }
}
