using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RacingGamesLaptime.Models;

[Table("laptime")]
public partial class Laptime
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("time")]
    public int Time { get; set; }

    [Column("car")]
    public string Car { get; set; } = null!;

    [Column("game_name")]
    public string GameName { get; set; } = null!;

    [Column("circuit")]
    public string Circuit { get; set; } = null!;

    [Column("car_category")]
    public string CarCategory { get; set; } = null!;

    [Column("circuit_layout")]
    public string CircuitLayout { get; set; } = null!;

    [Column("circuit_country")]
    public string CircuitCountry { get; set; } = null!;

    [Column("car_country")]
    public string CarCountry { get; set; } = null!;

    [Column("isCarMod")]
    public bool IsCarMod { get; set; }

    [Column("isCircuitMod")]
    public bool IsCircuitMod { get; set; } 
}
