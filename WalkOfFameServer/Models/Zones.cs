using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models
{
    public class Zone
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("City")]
        public int CityId { get; set; }

        [Required]
        [ForeignKey("ZoneType")]
        public int TypeId { get; set; }

        [Required]
        public int Quality { get; set; }

        [Required]
        public int InfrastructureQuality { get; set; }

        public virtual City City { get; set; } 
        public virtual ZoneType ZoneType { get; set; } 
    }
}
