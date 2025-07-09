using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class TbCustomer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string ShippingAddress { get; set; } = null!;

    public virtual ICollection<TbCartonPriceForm> TbCartonPriceForms { get; set; } = new List<TbCartonPriceForm>();

    public virtual ICollection<TbProductionOrder> TbProductionOrders { get; set; } = new List<TbProductionOrder>();
}
