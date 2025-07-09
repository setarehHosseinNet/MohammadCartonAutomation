using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class FlutStep
{
    public int FluteId { get; set; }

    public string FlutStep1 { get; set; } = null!;

    public virtual ICollection<TbCartonPriceForm> TbCartonPriceForms { get; set; } = new List<TbCartonPriceForm>();

    public virtual ICollection<TbMachin> TbMachins { get; set; } = new List<TbMachin>();
}
