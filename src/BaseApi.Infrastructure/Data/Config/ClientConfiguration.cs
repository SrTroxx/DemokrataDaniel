using BaseApi.Core.ProjectAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaseApi.Infrastructure.Data.Config;
public class ClientConfiguration : IEntityTypeConfiguration<Usuarios>
{
  public void Configure(EntityTypeBuilder<Usuarios> builder)
  {
    builder.ToTable("Usuarios", "dbo");

    builder.HasKey(a => a.Id);

    builder.Property(a => a.primer_nombre).IsRequired().HasMaxLength(50).IsUnicode(true);

    builder.Property(a => a.segundo_nombre).HasMaxLength(50).IsUnicode(true);

    builder.Property(a => a.primer_apellido).IsRequired().HasMaxLength(50).IsUnicode(true);

    builder.Property(a => a.segundo_apellido).HasMaxLength(50).IsUnicode(true);

    builder.Property(a => a.fecha_nacimiento).IsRequired();

    builder.Property(a => a.sueldo).IsRequired();

    builder.Property(a => a.fecha_creacion);

    builder.Property(a => a.fecha_modificacion);    
  }
}
