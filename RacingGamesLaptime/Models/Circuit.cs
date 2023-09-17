using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RacingGamesLaptime.Models;

[Table("circuit")]
public partial class Circuit
{

    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("country")]
    public string Country { get; set; } = null!;

    [Column("layout")]
    public string Layout { get; set; } = null!;

    [Column("length")]
    public int Length { get; set; }

    [Column("isMod")]
    public bool IsMod { get; set; }
}
