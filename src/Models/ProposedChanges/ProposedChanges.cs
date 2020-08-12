using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enums;

namespace Models.ProposedChanges
{
    public class ProposedChanges
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ChangeType ChangeType { get; set; }

        public string ProposedDataChanges { get; set; }

    }
}