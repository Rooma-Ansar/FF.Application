using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FF.Domain.Models
{
    public class Applicant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(11)")]
        public string FamilyName { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string CountryOfOrigin { get; set; }


        [Required]
        [Column(TypeName = "varchar(10)")]
        public string EmailAddress { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public bool Hired { get; set; }

    }
}
