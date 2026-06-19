using System;
using System.Collections.Generic;

namespace ClinicaMVC.Models;

public partial class Cita
{
    public int IdCita { get; set; }

    public int IdPaciente { get; set; }

    public int IdMedico { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly Hora { get; set; }

    public string? Estado { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<HistorialMedico> HistorialMedicos { get; set; } = new List<HistorialMedico>();

    public virtual Medico IdMedicoNavigation { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
