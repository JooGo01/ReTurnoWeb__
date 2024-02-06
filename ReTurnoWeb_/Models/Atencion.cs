using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Atencion
{
    public int Id { get; set; }

    public int? DiaId { get; set; }

    public int? SucursalServicioId { get; set; }

    public int HoraApertura { get; set; }

    public int HoraCierre { get; set; }

    public int PersonalServicio { get; set; }

    public int? EstadoBaja { get; set; }

    public virtual Dia? Dia_Id { get; set; }

    public virtual SucursalServicio? SucursalServicio { get; set; }
    public Atencion(int p_id, Dia p_dia_id, SucursalServicio p_sucursal_servicio_id, int p_hora_apertura, int p_hora_cierre, int p_personal_servicio, int p_estado_baja)
    {
        this.Id = p_id;
        this.Dia_Id = p_dia_id;
        this.SucursalServicio = p_sucursal_servicio_id;
        this.HoraApertura = p_hora_apertura;
        this.HoraCierre = p_hora_cierre;
        this.PersonalServicio = p_personal_servicio;
        this.EstadoBaja = p_estado_baja;
    }

    public Atencion() { }
}
