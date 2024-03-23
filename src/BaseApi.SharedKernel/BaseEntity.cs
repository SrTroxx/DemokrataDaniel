namespace BaseApi.SharedKernel
{
  // This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)
  public abstract class BaseEntity
  {
    public int Id { get; set; }

    public DateTime fecha_creacion { get; set; }

    public string? fecha_modificacion { get; set; }
  }
}
