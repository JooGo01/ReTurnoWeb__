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

    public SucursalServicio(int p_id, Sucursal p_id_sucursal, Subservicio p_id_subservicio, int p_tiempo_servicio, int p_estado_baja)
    {
        this.Id = p_id;
        this.Sucursal = p_id_sucursal;
        this.Subservicio = p_id_subservicio;
        this.TiempoServicio = p_tiempo_servicio;
        this.EstadoBaja = p_estado_baja;
    }

    public SucursalServicio() { }
}
