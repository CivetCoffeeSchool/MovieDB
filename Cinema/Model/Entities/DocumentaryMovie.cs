using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("DOCU_MOVIES")]
public class DocumentaryMovie:Movie
{
    [Column("TOPIC")]
    [Required]
    [StringLength(50)]
    public string Topic { get; set; }
}