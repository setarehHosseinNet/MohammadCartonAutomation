using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class TbMachin
{
    public int MachinId { get; set; }

    public int FlutId { get; set; }

    public string MachinName { get; set; } = null!;

    public virtual FlutStep Flut { get; set; } = null!;
}
