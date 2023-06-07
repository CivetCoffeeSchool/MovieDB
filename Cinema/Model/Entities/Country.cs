using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("E_COUNTRIES")]
public class Country {
    [StringLength(100)]
    [Key, Column("NAME")]
    public string Name {get; set; }
}