using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class TbProductionOrder
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public string ProductCode { get; set; } = null!;

    public int QuantityRequested { get; set; }

    public DateOnly RequiredDate { get; set; }

    public DateOnly CreateDate { get; set; }

    public virtual TbCustomer Customer { get; set; } = null!;

    public virtual ICollection<TbProformaDetail> TbProformaDetails { get; set; } = new List<TbProformaDetail>();
}
