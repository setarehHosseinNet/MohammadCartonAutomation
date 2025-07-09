using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class TbBom
{
    public int Bomid { get; set; }

    public string ParmetrName { get; set; } = null!;

    public int MaterialId { get; set; }

    public virtual TbMaterial Material { get; set; } = null!;

    public virtual ICollection<TbProformaDetail> TbProformaDetails { get; set; } = new List<TbProformaDetail>();
}
