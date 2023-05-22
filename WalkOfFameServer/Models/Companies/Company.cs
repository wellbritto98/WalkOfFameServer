using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkOfFameServer.Enums;
using WalkOfFameServer.Models.Cities;

namespace WalkOfFameServer.Models.Companies
{

    public class Company
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("CityId")]
        public City City { get; set; }

        public CompanyTypeEnum Type { get; set; }

        public ulong Money { get; set; }
    }
}
