using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class TbCartonSpecification
{
    public int SpecId { get; set; }

    public int FormId { get; set; }

    public double Length { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public string LayerType { get; set; } = null!;

    public string PieceType { get; set; } = null!;

    public string DoorType { get; set; } = null!;

    public string DoorCount { get; set; } = null!;

    public double? DoorEdgeLength { get; set; }

    public bool IsManualEdge { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public virtual TbCartonPriceForm Form { get; set; } = null!;
}
