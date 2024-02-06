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

    public Direccion(int p_id, string p_calle, int p_altura, string p_codigo_postal, int p_piso, string p_provincia, string p_ciudad, string p_departamento)
    {
        Id = p_id;
        Calle = p_calle;
        Altura = p_altura;
        CodigoPostal = p_codigo_postal;
        Piso = p_piso;
        Provincia = p_provincia;
        Ciudad = p_ciudad;
        Departamento = p_departamento;
    }

    public Direccion() { }
}
