using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? RazonSocial { get; set; }

    public int? RubroId { get; set; }

    public int? EstadoBaja { get; set; }

    public int? UsuarioId { get; set; }

    public virtual Rubro? Rubro { get; set; }

    public virtual ICollection<Sucursal> Sucursals { get; set; } = new List<Sucursal>();

    public virtual Usuario? Usuario { get; set; }
}
