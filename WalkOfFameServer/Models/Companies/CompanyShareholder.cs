using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Models.Characters;

namespace WalkOfFameServer.Models.Companies
{
    [PrimaryKey("CharacterId", "CompanyId")]
    public class CompanyShareholder
    {
        [Required]
        [ForeignKey("CharacterId")]
        public virtual Character Character { get; set; }

        [Required]
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        [Required]
        public int Shares { get; set; }

        [DefaultValue(false)]
        public bool IsPresident { get; set; }
    }
}
