using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace ReTurnoWeb_.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Dni { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Contrasenia { get; set; }

    public string? TipoUsuario { get; set; }

    public int? DireccionId { get; set; }

    public int? EstadoBaja { get; set; }

    public virtual ICollection<Administracion> Administracions { get; set; } = new List<Administracion>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Direccion? Direccion { get; set; }

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    public Usuario(int p_id, string p_nombre, string p_apellido, string p_dni, string p_telefono, string p_email, string p_contrasenia, string p_tipo_usuario, Direccion p_direccion, int p_estado_baja)
    {
        this.Id = p_id;
        this.Nombre = p_nombre;
        this.Apellido = p_apellido;
        this.Dni = p_dni;
        this.Telefono = p_telefono;
        this.Email = p_email;
        this.Contrasenia = p_contrasenia;
        this.TipoUsuario = p_tipo_usuario;
        this.Direccion = p_direccion;
        this.EstadoBaja = p_estado_baja;
    }

    public Usuario()
    {

    }
}
