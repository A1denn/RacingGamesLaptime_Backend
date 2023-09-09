using System;
using System.Collections.Generic;

namespace RacingGamesLaptime.Data;

public partial class Circuit
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Country { get; set; }

    public string? Layout { get; set; }

    public int? Length { get; set; }

    public sbyte? IsMod { get; set; }

    public virtual ICollection<Laptime> Laptimes { get; set; } = new List<Laptime>();
}
