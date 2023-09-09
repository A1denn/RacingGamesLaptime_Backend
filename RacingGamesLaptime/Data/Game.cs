using System;
using System.Collections.Generic;

namespace RacingGamesLaptime.Data;

public partial class Game
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Platform { get; set; } = null!;

    public int ReleaseYear { get; set; }
}
