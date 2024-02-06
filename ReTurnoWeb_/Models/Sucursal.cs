using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Sucursal
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public int? DireccionId { get; set; }

    public string? Telefono { get; set; }

    public int? EstadoBaja { get; set; }

    public virtual ICollection<Administracion> Administracions { get; set; } = new List<Administracion>();

    public virtual Cliente? Cliente { get; set; }

    public virtual Direccion? Direccion { get; set; }

    public virtual ICollection<SucursalServicio> SucursalServicios { get; set; } = new List<SucursalServicio>();

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    public Sucursal(int p_id, Cliente p_cliente, Direccion p_direccion, string p_telefono, int p_estado_baja)
    {
        this.Id = p_id;
        this.Cliente = p_cliente;
        this.Direccion = p_direccion;
        this.Telefono = p_telefono;
        this.EstadoBaja = p_estado_baja;
    }

    public Sucursal() { }

    public Sucursal(int p_id) { Id = p_id; }
}
