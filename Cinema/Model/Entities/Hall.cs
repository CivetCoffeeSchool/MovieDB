using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities;

[Table(("HALLS"))]
public class Hall{
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("HALL_ID")]
    public int Id { get; set; }
    
    [Required, Range(0, 500)]
    [Column("CAPACITY")]
    public int Capacity { get; set; }
    
    [Required, StringLength(45)]
    [Column("NAME")]
    public string Name { get; set; }
    
    [Required, StringLength(45)]
    [Column("CODE")]
    public string Code { get; set; }
    
    //relation
    public Cinema Cinema { get; set; }
    
    [Column("CINEMA_ID")]
    public int CinemaId { get; set; }
}