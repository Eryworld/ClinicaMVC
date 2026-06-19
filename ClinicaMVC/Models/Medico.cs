using System;
using System.Collections.Generic;

namespace ClinicaMVC.Models;

public partial class Medico
{
    public int IdMedico { get; set; }

    public string Nombre { get; set; } = null!;

    public string Cedula { get; set; } = null!;

    public string Especialidad { get; set; } = null!;

    public string? Telefono { get; set; }

    public string Turno { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();

    public virtual ICollection<HistorialMedico> HistorialMedicos { get; set; } = new List<HistorialMedico>();
}
