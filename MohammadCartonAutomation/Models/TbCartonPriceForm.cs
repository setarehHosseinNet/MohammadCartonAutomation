using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class TbCartonPriceForm
{
    public int FormId { get; set; }

    public int CustomerId { get; set; }

    public int FlutId { get; set; }

    public string ProductCode { get; set; } = null!;

    public string CartonType { get; set; } = null!;

    public DateOnly? LastOrderDate { get; set; }

    public decimal? LastPrice { get; set; }

    public DateOnly? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public int FinalAmount { get; set; }

    public virtual TbCustomer Customer { get; set; } = null!;

    public virtual FlutStep Flut { get; set; } = null!;

    public virtual ICollection<TbCartonSpecification> TbCartonSpecifications { get; set; } = new List<TbCartonSpecification>();
}
