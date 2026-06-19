using System;
using System.Collections.Generic;

namespace ClinicaMVC.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public int IdRol { get; set; }

    public bool? Activo { get; set; }

    public virtual Role IdRolNavigation { get; set; } = null!;
}
