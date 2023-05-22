using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkOfFameServer.Models.Cities
{
    [Table("Countries")]
    public class Country
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [InverseProperty("Country")]
        public List<City> Cities { get; } = new();
    }
}
