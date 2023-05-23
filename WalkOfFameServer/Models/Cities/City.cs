using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models.Cities
{
    public class City
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        public long CountryId { get; set; }

        [Required]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }
        
        public long? DefaultLocationId { get; set; }
        
        [ForeignKey(nameof(DefaultLocationId))]
        public virtual Location? DefaultLocation { get; set; }

        [Required]
        [StringLength(50)] 
        public string Timezone { get; set; }
    }
}
