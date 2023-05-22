using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkOfFameServer.Enums;
using WalkOfFameServer.Models.Characters;
using WalkOfFameServer.Models.Companies;

namespace WalkOfFameServer.Models.Cities
{

    public class Location
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("ZoneId")]
        [Required]
        public Zone Zone { get; set; }

        [DefaultValue(0)]
        [Required]
        public int Quality { get; set; }

        [ForeignKey("ScoringId")]
        [Required]
        public Scoring Scoring { get; set; }

        [Required]
        public LocationTypeEnum LocationType { get; set; }

        [ForeignKey("CompanyId")]
        [Required]
        public Company Company { get; set; }
        
        [ForeignKey("OwnerId")]
        [Required]
        public Character Owner { get; set; }

        [DefaultValue(0)]
        public ulong Money { get; set; }
    }
}
