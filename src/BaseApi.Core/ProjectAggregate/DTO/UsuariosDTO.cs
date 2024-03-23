using System.ComponentModel.DataAnnotations;

namespace BaseApi.Core.ProjectAggregate.DTO;

public class UsuariosDTO
{
  [Required(ErrorMessage = "El Primer Nombre Requerido")]
  [MaxLength(50, ErrorMessage = "Solo se puede poner un maximo de 50 Caracteres")]
  public string primer_nombre { get; set; }

  [MaxLength(50, ErrorMessage = "Solo se puede poner un maximo de 50 Caracteres")]
  public string? segundo_nombre { get; set; }

  [Required(ErrorMessage = "El Primer Apellido Requerido")]
  [MaxLength(50, ErrorMessage = "Solo se puede poner un maximo de 50 Caracteres")]
  public string primer_apellido { get; set; }

  [MaxLength(50, ErrorMessage = "Solo se puede poner un maximo de 50 Caracteres")]
  public string? segundo_apellido { get; set; }

  [Required(ErrorMessage = "Fecha de Cumpleaños Requerido")]
  public DateTime fecha_nacimiento { get; set; }

  [Required(ErrorMessage = "Error Sueldo Requerido")]
  public Decimal sueldo { get; set; }
}
