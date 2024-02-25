using System;
using System.Collections.Generic;

namespace Empresa22.Models;

public partial class Ventum
{
    public int VentaId { get; set; }

    public int? ClienteId { get; set; }

    public int? EmpleadoId { get; set; }

    public decimal? Monto { get; set; }

    public DateTime? FechaVenta { get; set; }

    public string? Detalle { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Empleado? Empleado { get; set; }
}
