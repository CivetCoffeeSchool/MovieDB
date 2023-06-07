using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public enum EEntertainment
{
    Thriller,Comedy,Crime,Horror, Action, Drama
}

[Table("ENTERTAINMENT_MOVIES")]
public class EntertainmentMovie:Movie
{
    [Column("CATEGORY")]
    public EEntertainment Category { get; set; }
}