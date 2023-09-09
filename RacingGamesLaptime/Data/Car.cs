using System;
using System.Collections.Generic;

namespace RacingGamesLaptime.Data;

public partial class Car
{
    public Guid Id { get; set; }

    public string Model { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string OriginCountry { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Engine { get; set; } = null!;

    public string Tyre { get; set; } = null!;

    public sbyte IsMod { get; set; }
}
