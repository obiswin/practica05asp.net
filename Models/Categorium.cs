using System;
using System.Collections.Generic;

namespace Empresa22.Models;

public partial class Categorium
{
    public int CategoriaId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
