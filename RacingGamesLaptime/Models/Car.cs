using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RacingGamesLaptime.Models;

[Table("car")]
public partial class Car
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("model")]
    public string Model { get; set; } = null!;

    [Column("brand")]
    public string Brand { get; set; } = null!;

    [Column("origin_country")]
    public string OriginCountry { get; set; } = null!;

    [Column("category")]
    public string Category { get; set; } = null!;

    [Column("engine")]
    public string Engine { get; set; } = null!;

    [Column("tyre")]
    public string Tyre { get; set; } = null!;

    [Column("isMod")]
    public bool IsMod { get; set; }
}
