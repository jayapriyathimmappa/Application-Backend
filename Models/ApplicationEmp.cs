using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class ApplicationEmp
{
    public int EmployeeCode { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string Ctc { get; set; } = null!;

    public string Basic { get; set; } = null!;

    public string? HraType { get; set; }

    public string? Hra { get; set; }

    public string? Pf { get; set; }

    public string? Lta { get; set; }

    public string? Fual { get; set; }

    public string? Special { get; set; }
}
