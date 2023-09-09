using System;
using System.Collections.Generic;

namespace RacingGamesLaptime.Data;

public partial class Circuit
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Layout { get; set; } = null!;

    public int Length { get; set; }

    public sbyte IsMod { get; set; }
}
