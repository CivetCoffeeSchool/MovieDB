using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("CINEMAS")]
public class Cinema
{
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("CINEMA_ID")]
    public int Id { get; set; }
    
    [Required,StringLength((100))]
    [Column("LABEL")]
    public string Label { get; set; }
    
    public Address Address { get; set; }
    
    [Required]
    [Column("ADDRESS_ID")]
    public int AddressId { get; set; }
}