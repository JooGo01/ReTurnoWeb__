using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class SucursalServicio
{
    public int Id { get; set; }

    public int? SucursalId { get; set; }

    public int? SubservicioId { get; set; }

    public int TiempoServicio { get; set; }

    public int? EstadoBaja { get; set; }

    public virtual ICollection<Atencion> Atencions { get; set; } = new List<Atencion>();

    public virtual Subservicio? Subservicio { get; set; }

    public virtual Sucursal? Sucursal { get; set; }
}
