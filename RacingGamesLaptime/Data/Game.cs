using System;
using System.Collections.Generic;

namespace RacingGamesLaptime.Data;

public partial class Game
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Platform { get; set; }

    public int? ReleaseYear { get; set; }

    public virtual ICollection<Laptime> Laptimes { get; set; } = new List<Laptime>();
}
