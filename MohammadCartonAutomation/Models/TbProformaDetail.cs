using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class TbProformaDetail
{
    public int VariationId { get; set; }

    public int OrderId { get; set; }

    public int Bomid { get; set; }

    public decimal Quantity { get; set; }

    public int Total { get; set; }

    public virtual TbBom Bom { get; set; } = null!;

    public virtual TbProductionOrder Order { get; set; } = null!;
}
