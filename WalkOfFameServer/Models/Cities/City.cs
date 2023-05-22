using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models.Cities
{
    public class City
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)] 
        public string Country { get; set; }

        [Required]
        [StringLength(50)] 
        public string Timezone { get; set; }
        
        [InverseProperty("City")]
        public List<Zone> Zones { get; } = new();
    }
}
