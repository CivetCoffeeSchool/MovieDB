using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ADDRESSES")]
public class Address {
    [Column("ADDRESS_ID")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required, StringLength((8))]
    [Column("POSTAL_CODE")]
    public string PostalCode { get; set; }
    
    [Required,StringLength(100)]
    [Column("LOCATION")]
    public string Location { get; set; }
    
    [Required, StringLength(100)]
    [Column("STREET")]
    public string Street { get; set; }
    
    public State State { get; set; }
    
    [Required]
    [Column("STATE")]
    public string StateCode { get; set; }
    
    public Country Country { get; set; }
    
    [Required]
    [Column("COUNTRY")]
    public string CountryName { get; set; }
}