﻿using System;
using System.Collections.Generic;

namespace Inventory_for_home.Models;

public partial class CatTypeStock
{
    public int IdTypeStock { get; set; }

    public string TypeStockName { get; set; } = null!;

    public bool Active { get; set; }
}
