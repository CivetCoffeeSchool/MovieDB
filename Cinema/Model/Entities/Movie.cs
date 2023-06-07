using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("MOVIES")]
public class Movie {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    [Column("MOVIE_ID")]
    public int Id { get; set; }
    
    [Required]
    [Column("TITLE")]
    [StringLength(100)]
    public string Title { get; set; }
    
    [Required]
    [Column("DIRECTOR")]
    [StringLength(50)]
    public string Director { get; set; }
    
    [Required]
    [Column("LENGTH")]
    [MinLength(0)]
    [MaxLength(900)]
    // [Range(0, 900)]
    public int Length { get; set; }
    
    [Required]
    [Column("SHORT_DESCRIPTION")]
    [StringLength(400)]
    public string ShortDescription { get; set; }
}