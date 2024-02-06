using System;
using System.Collections.Generic;

namespace ReTurnoWeb_.Models;

public partial class Dia
{
    public int Id { get; set; }

    public string NombreDia { get; set; } = null!;

    public virtual ICollection<Atencion> Atencions { get; set; } = new List<Atencion>();
}
