using System;
using System.Collections.Generic;

namespace MVCTutorial4.Models;

public partial class Empleado
{
    public long Id { get; set; }

    public string Nombre { get; set; }

    public long? IdArea { get; set; }

    public virtual Empresa? IdAreaNavigation { get; set; }
}
