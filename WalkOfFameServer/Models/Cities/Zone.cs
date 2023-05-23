using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkOfFameServer.Enums;

namespace WalkOfFameServer.Models.Cities
{
    [Table("Zones")]
    public class Zone
    {
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Quality { get; set; }

        [Required]
        [DefaultValue(0)]
        public int InfrastructureQuality { get; set; }
        
        public long CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; } 
        
        [Required]
        public ZoneTypeEnum Type { get; set; }
    }
}
