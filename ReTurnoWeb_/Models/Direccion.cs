using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Direccion
{
    public int Id { get; set; }

    public string? Calle { get; set; }

    public int? Altura { get; set; }

    public string? CodigoPostal { get; set; }

    public int? Piso { get; set; }

    public string? Provincia { get; set; }

    public string? Ciudad { get; set; }

    public string? Departamento { get; set; }

    public virtual ICollection<Sucursal> Sucursals { get; set; } = new List<Sucursal>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
