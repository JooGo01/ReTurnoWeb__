using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Rubro
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
