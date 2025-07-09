using System;
using System.Collections.Generic;

namespace MohammadCartonAutomation.Models;

public partial class CalculationFormula
{
    public int FormulaId { get; set; }

    public string FormulaName { get; set; } = null!;

    public string? FormulaDescription { get; set; }

    public string FormulaExpression { get; set; } = null!;

    public string? Variables { get; set; }

    public string? OutputUnit { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }
}
