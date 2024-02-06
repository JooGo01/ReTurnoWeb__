using ReTurnoWeb_.Servicios.Contrato;
using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Administracion
{
    public int Id { get; set; }

    public int? SucursalId { get; set; }

    public int? UsuarioId { get; set; }

    public int? EstadoBaja { get; set; }

    public virtual Sucursal? Sucursal { get; set; }

    public virtual Usuario? Usuario { get; set; }

    public Administracion(int p_id, Sucursal p_suc, Usuario p_usuario, int p_estado_baja)
    {
        Id = p_id;
        Sucursal = p_suc;
        Usuario = p_usuario;
        EstadoBaja = p_estado_baja;
    }

    public Administracion() { }
}
