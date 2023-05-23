using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkOfFameServer.Enums;
using WalkOfFameServer.Models.Characters;
using WalkOfFameServer.Models.Companies;

namespace WalkOfFameServer.Models.Cities
{
    [Table("Locations")]
    public class Location
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DefaultValue(0)]
        [Required]
        public int Quality { get; set; }

        [Required]
        public ScoringEnum Scoring { get; set; }

        [Required]
        public LocationTypeEnum LocationType { get; set; }
        
        public long ZoneId { get; set; }

        [ForeignKey(nameof(ZoneId))]
        [Required]
        public virtual Zone Zone { get; set; }
        
        public long? CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public virtual Company? Company { get; set; }
        
        public long? OwnerId { get; set; }
        
        [ForeignKey(nameof(OwnerId))]
        public virtual Character? Owner { get; set; }

        [DefaultValue(0)]
        public ulong Money { get; set; }
    }
}
