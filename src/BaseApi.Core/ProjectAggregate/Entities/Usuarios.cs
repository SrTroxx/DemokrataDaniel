using BaseApi.SharedKernel;
using BaseApi.SharedKernel.Interfaces;

namespace BaseApi.Core.ProjectAggregate.Entities;

public class Usuarios : BaseEntity, IAggregateRoot
{
  public string primer_nombre { get; set; }

  public string? segundo_nombre { get; set; }

  public string primer_apellido { get; set; }

  public string? segundo_apellido { get; set; }

  public DateTime fecha_nacimiento { get; set; }

  public Decimal sueldo { get; set; }
  
}
