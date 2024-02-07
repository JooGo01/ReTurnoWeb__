using ReTurnoWeb_.Servicios.Contrato;
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

    public Turno(int p_id, Sucursal p_sucursal, Usuario p_usuario, DateTime p_fecha_ini, DateTime p_fecha_fin, int p_estado_baja, Subservicio p_subservicio)
    {
        this.Id = p_id;
        this.Sucursal = p_sucursal;
        this.Usuario = p_usuario;
        this.FechaIni = p_fecha_ini;
        this.FechaFin = p_fecha_fin;
        this.EstadoBaja = p_estado_baja;
        this.Subservicio = p_subservicio;
    }

    public Turno() { }
}
