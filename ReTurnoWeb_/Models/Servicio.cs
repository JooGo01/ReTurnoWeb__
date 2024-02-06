using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Servicio
{
    public int Id { get; set; }

    public string? NombreServicio { get; set; }

    public virtual ICollection<Subservicio> Subservicios { get; set; } = new List<Subservicio>();

    public Servicio(int p_id, String p_nombre_servicio)
    {
        this.Id = p_id;
        this.NombreServicio = p_nombre_servicio;
    }

    public Servicio()
    {
    }
}
