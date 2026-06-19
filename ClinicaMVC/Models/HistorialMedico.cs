using System;
using System.Collections.Generic;

namespace ClinicaMVC.Models;

public partial class HistorialMedico
{
    public int IdHistorial { get; set; }

    public int IdPaciente { get; set; }

    public int IdMedico { get; set; }

    public int? IdCita { get; set; }

    public DateTime? FechaConsulta { get; set; }

    public string? Sintomas { get; set; }

    public string? Diagnostico { get; set; }

    public string? Tratamiento { get; set; }

    public virtual Cita? IdCitaNavigation { get; set; }

    public virtual Medico IdMedicoNavigation { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
