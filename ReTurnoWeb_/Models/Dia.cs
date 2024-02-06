using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Dia
{
    public int Id { get; set; }

    public string NombreDia { get; set; } = null!;

    public virtual ICollection<Atencion> Atencions { get; set; } = new List<Atencion>();

    public Dia(int p_id, String p_nombre_dia)
    {
        this.Id = p_id;
        this.NombreDia = p_nombre_dia;
    }

    public Dia() { }
}
