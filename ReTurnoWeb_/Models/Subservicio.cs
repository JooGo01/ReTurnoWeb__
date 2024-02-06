using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Subservicio
{
    public int Id { get; set; }

    public string? NombreServicio { get; set; }

    public int? ServicioId { get; set; }

    public virtual Servicio? Servicio { get; set; }

    public virtual ICollection<SucursalServicio> SucursalServicios { get; set; } = new List<SucursalServicio>();

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    public Subservicio(int p_id, String p_nombre_servicio, Servicio p_id_servicio)
    {
        this.Id = p_id;
        this.NombreServicio = p_nombre_servicio;
        this.Servicio = p_id_servicio;
    }

    public Subservicio() { }
}
