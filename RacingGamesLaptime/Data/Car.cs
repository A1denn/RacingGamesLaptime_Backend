using System;
using System.Collections.Generic;

namespace RacingGamesLaptime.Data;

public partial class Car
{
    public Guid Id { get; set; }

    public string? Model { get; set; }

    public string? Brand { get; set; }

    public string? OriginCountry { get; set; }

    public string? Category { get; set; }

    public string? Engine { get; set; }

    public string? Tyre { get; set; }

    public sbyte? IsMod { get; set; }

    public virtual ICollection<Laptime> Laptimes { get; set; } = new List<Laptime>();
}
