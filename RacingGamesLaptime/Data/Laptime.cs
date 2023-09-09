using System;
using System.Collections.Generic;

namespace RacingGamesLaptime.Data;

public partial class Laptime
{
    public Guid Id { get; set; }

    public int Time { get; set; }

    public string Car { get; set; } = null!;

    public string GameName { get; set; } = null!;

    public string Circuit { get; set; } = null!;

    public string CarCategory { get; set; } = null!;

    public string CircuitLayout { get; set; } = null!;

    public string CircuitCountry { get; set; } = null!;

    public string CarCountry { get; set; } = null!;

    public string IsCarMod { get; set; } = null!;

    public string IsCircuitMod { get; set; } = null!;
}
