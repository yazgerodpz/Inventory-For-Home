using System;
using System.Collections.Generic;

namespace Inventory_for_home.Models;

public partial class CatTypePrioritary
{
    public int IdTypePrioritary { get; set; }

    public string TypePrioritaryName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Active { get; set; }
}
