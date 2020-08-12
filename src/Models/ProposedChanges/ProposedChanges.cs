using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.ProposedChanges
{
    public class ProposedChanges
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ChangeType { get; set; }

        public string ProposedDataChanges { get; set; }

    }
}