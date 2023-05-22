using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("ScoringName")]
        [Required]
        public Scoring Scoring { get; set; }

        [ForeignKey("LocationTypeId")]
        [Required]
        public LocationType LocationType { get; set; }

        [ForeignKey("CompanyId")]
        [Required]
        public Company Company { get; set; }

        [DefaultValue(0)]
        public ulong Money { get; set; }



    }
}
