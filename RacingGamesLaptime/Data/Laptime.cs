using System;
using System.Collections.Generic;

namespace RacingGamesLaptime.Data;

public partial class Laptime
{
    public Guid Id { get; set; }

    public int? Time { get; set; }

    public Guid? Car { get; set; }

    public Guid? GameName { get; set; }

    public Guid? Circuit { get; set; }

    public string? CarCategory { get; set; }

    public virtual Car? CarNavigation { get; set; }

    public virtual Circuit? CircuitNavigation { get; set; }

    public virtual Game? GameNameNavigation { get; set; }
}
