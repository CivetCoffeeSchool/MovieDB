using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("PERSONS")]
public class Person {
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("PERSON_ID")]
    public int Id { get; set; }
    
    [Required, StringLength(45)]
    [Column("FIRST_NAME")]
    public string FirstName { get; set; }
    
    [Required, StringLength(45)]
    [Column("LAST_NAME")]
    public string LastName { get; set; }
}