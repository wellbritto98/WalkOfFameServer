using System;
using System.ComponentModel.DataAnnotations;

namespace WalkOfFameServer.Models.Cities
{
    public class LocationType
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)] 
        public string Name { get; set; }
    }
}
