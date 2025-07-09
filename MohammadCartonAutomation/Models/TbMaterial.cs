using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class TbMaterial
{
    public int MaterialId { get; set; }

    public string MaterialName { get; set; } = null!;

    public int Price { get; set; }

    public virtual ICollection<TbBom> TbBoms { get; set; } = new List<TbBom>();
}
