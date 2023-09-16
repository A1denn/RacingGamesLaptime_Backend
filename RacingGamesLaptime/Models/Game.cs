using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RacingGamesLaptime.Models;

[Table("game")]
public partial class Game
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("platform")]
    public string Platform { get; set; } = null!;

    [Column("release_year")]
    public int ReleaseYear { get; set; }
}
