using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models.Cities
{
    [Table("Zones")]
    public class Zone
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Quality { get; set; }

        [Required]
        public int InfrastructureQuality { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; } 
        
        [ForeignKey("ZoneTypeId")]
        public ZoneType Type { get; set; } 
    }
}
