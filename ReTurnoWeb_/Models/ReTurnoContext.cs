using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReTurnoWeb_.Models;

public partial class ReTurnoContext : DbContext
{
    public ReTurnoContext()
    {
    }

    public ReTurnoContext(DbContextOptions<ReTurnoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administracion> Administracions { get; set; }

    public virtual DbSet<Atencion> Atencions { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Direccion> Direccions { get; set; }

    public virtual DbSet<Dia> Dias { get; set; }

    public virtual DbSet<Rubro> Rubros { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Subservicio> Subservicios { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<SucursalServicio> SucursalServicios { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-8Q1CKL2\\SQLEXPRESS; database=ReTurno; integrated security=true; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administracion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__administ__3213E83F468745BB");

            entity.ToTable("administracion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstadoBaja)
                .HasDefaultValue(0)
                .HasColumnName("estado_baja");
            entity.Property(e => e.SucursalId).HasColumnName("sucursal_id");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Administracions)
                .HasForeignKey(d => d.SucursalId)
                .HasConstraintName("FK__administr__sucur__66603565");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Administracions)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__administr__usuar__6754599E");
        });

        modelBuilder.Entity<Atencion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__atencion__3213E83FB53B321C");

            entity.ToTable("atencion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DiaId).HasColumnName("dia_id");
            entity.Property(e => e.EstadoBaja)
                .HasDefaultValue(0)
                .HasColumnName("estado_baja");
            entity.Property(e => e.HoraApertura).HasColumnName("hora_apertura");
            entity.Property(e => e.HoraCierre).HasColumnName("hora_cierre");
            entity.Property(e => e.PersonalServicio).HasColumnName("personal_servicio");
            entity.Property(e => e.SucursalServicioId).HasColumnName("sucursal_servicio_id");

            entity.HasOne(d => d.Dia_Id).WithMany(p => p.Atencions)
                .HasForeignKey(d => d.DiaId)
                .HasConstraintName("FK__atencion__dia_id__68487DD7");

            entity.HasOne(d => d.SucursalServicio).WithMany(p => p.Atencions)
                .HasForeignKey(d => d.SucursalServicioId)
                .HasConstraintName("FK__atencion__sucurs__693CA210");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cliente__3213E83FDBC12414");

            entity.ToTable("cliente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstadoBaja)
                .HasDefaultValue(0)
                .HasColumnName("estado_baja");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("razon_social");
            entity.Property(e => e.RubroId).HasColumnName("rubro_id");
            entity.Property(e => e.UsuarioId)
                .HasDefaultValue(0)
                .HasColumnName("usuario_id");

            entity.HasOne(d => d.Rubro).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.RubroId)
                .HasConstraintName("FK__cliente__rubro_i__6A30C649");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("fk_usuario_id");
        });

        modelBuilder.Entity<Direccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__direccio__3213E83FB23476A7");

            entity.ToTable("direccion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Altura).HasColumnName("altura");
            entity.Property(e => e.Calle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Departamento)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("departamento");
            entity.Property(e => e.Piso).HasColumnName("piso");
            entity.Property(e => e.Provincia)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("provincia");
        });

        modelBuilder.Entity<Dia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dia__3213E83F0C456C16");

            entity.ToTable("dia");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nombre_dia");
        });

        modelBuilder.Entity<Rubro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__rubro__3213E83FF1DA6FF4");

            entity.ToTable("rubro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__servicio__3213E83F5B606AA0");

            entity.ToTable("servicio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NombreServicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_servicio");
        });

        modelBuilder.Entity<Subservicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__subservi__3213E83F38F13E9E");

            entity.ToTable("subservicio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NombreServicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_servicio");
            entity.Property(e => e.ServicioId).HasColumnName("servicio_id");

            entity.HasOne(d => d.Servicio).WithMany(p => p.Subservicios)
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("FK__subservic__servi__70DDC3D8");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sucursal__3213E83F3586D691");

            entity.ToTable("sucursal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.DireccionId).HasColumnName("direccion_id");
            entity.Property(e => e.EstadoBaja)
                .HasDefaultValue(0)
                .HasColumnName("estado_baja");
            entity.Property(e => e.Telefono)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__sucursal__client__6C190EBB");

            entity.HasOne(d => d.Direccion).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.DireccionId)
                .HasConstraintName("FK__sucursal__direcc__6D0D32F4");
        });

        modelBuilder.Entity<SucursalServicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sucursal__3213E83F0FB972C5");

            entity.ToTable("sucursal_servicio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstadoBaja)
                .HasDefaultValue(0)
                .HasColumnName("estado_baja");
            entity.Property(e => e.SubservicioId).HasColumnName("subservicio_id");
            entity.Property(e => e.SucursalId).HasColumnName("sucursal_id");
            entity.Property(e => e.TiempoServicio).HasColumnName("tiempo_servicio");

            entity.HasOne(d => d.Subservicio).WithMany(p => p.SucursalServicios)
                .HasForeignKey(d => d.SubservicioId)
                .HasConstraintName("FK__sucursal___subse__6E01572D");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.SucursalServicios)
                .HasForeignKey(d => d.SucursalId)
                .HasConstraintName("FK__sucursal___sucur__6EF57B66");
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__turno__3213E83F648E749A");

            entity.ToTable("turno");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstadoBaja)
                .HasDefaultValue(0)
                .HasColumnName("estado_baja");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.SubservicioId).HasColumnName("subservicio_id");
            entity.Property(e => e.SucursalId).HasColumnName("sucursal_id");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Subservicio).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.SubservicioId)
                .HasConstraintName("FK__turno__subservic__6FE99F9F");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.SucursalId)
                .HasConstraintName("FK__turno__sucursal___71D1E811");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__turno__usuario_i__72C60C4A");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuario__3213E83FDD18952D");

            entity.ToTable("usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Contrasenia)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("contrasenia");
            entity.Property(e => e.DireccionId).HasColumnName("direccion_id");
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EstadoBaja)
                .HasDefaultValue(0)
                .HasColumnName("estado_baja");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo_usuario");

            entity.HasOne(d => d.Direccion).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.DireccionId)
                .HasConstraintName("FK__usuario__direcci__73BA3083");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
