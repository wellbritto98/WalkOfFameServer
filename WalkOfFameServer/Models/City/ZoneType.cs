using System;
using System.ComponentModel.DataAnnotations;

namespace WalkOfFameServer.Models.City
{
    public class ZoneType
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
