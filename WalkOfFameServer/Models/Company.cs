using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using WalkOfFameServer.Models.Cities;

namespace WalkOfFameServer.Models
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

        public enum CompanyType
        { 
          PRIVATE,
          PUBLIC
        }
    
        public CompanyType Type { get; set; }

        public ulong Money { get; set; }

        


    }
}
