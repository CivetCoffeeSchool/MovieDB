using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("E_STATES")]
public class State {
        [StringLength(100)]
        [Key, Column("NAME")]
        public string Name {get; set; }
}