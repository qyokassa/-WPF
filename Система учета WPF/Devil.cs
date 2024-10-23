﻿using System;
using System.Collections.Generic;

namespace Система_учета_WPF;

public partial class Devil
{
    public int Id { get; set; }

    /// <summary>
    /// погоняло
    /// </summary>
    public string Nick { get; set; } = null!;

    /// <summary>
    /// кол-во душ
    /// </summary>
    public int Rank { get; set; }

    public int Year { get; set; }

    public virtual ICollection<Rack> Racks { get; set; } = new List<Rack>();
}
