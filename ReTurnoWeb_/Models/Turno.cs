using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Turno
{
    public int Id { get; set; }

    public int? SucursalId { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? EstadoBaja { get; set; }

    public int? SubservicioId { get; set; }

    public virtual Subservicio? Subservicio { get; set; }

    public virtual Sucursal? Sucursal { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
