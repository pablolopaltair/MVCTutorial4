using System;
using System.Collections.Generic;

namespace MVCTutorial4.Models;

public partial class Empresa
{
    public long Id { get; set; }

    public string Area { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
