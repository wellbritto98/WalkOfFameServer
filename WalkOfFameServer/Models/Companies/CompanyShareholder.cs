using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkOfFameServer.Models.Characters;

namespace WalkOfFameServer.Models.Companies
{
    public class CompanyShareholder
    {
        [Key]
        [ForeignKey("CharacterId")]
        [Required]
        public Character CharacterId { get; set; }

        [Required]
        [ForeignKey("CompanyId")]
        public Company CompanyId { get; set; }

        [Required]
        public int Shares { get; set; }

        [DefaultValue(0)]
        public short IsPresident { get; set; }
    }
}
