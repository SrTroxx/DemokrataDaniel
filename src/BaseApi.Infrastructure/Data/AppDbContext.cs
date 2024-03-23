using Ardalis.EFCore.Extensions;
using BaseApi.Core.ProjectAggregate.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BaseApi.Infrastructure.Data;

public class AppDbContext : DbContext
{
  private readonly IMediator? _mediator;

  public AppDbContext(DbContextOptions options) : base(options)
  {
  }

  //public AppDbContext(DbContextOptions<AppDbContext> options, IMediator? mediator)
  //    : base(options)
  //{
  //  _mediator = mediator;
  //}

  public DbSet<Usuarios> usuarios => Set<Usuarios>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();

    // alternately this is built-in to EF Core 2.2
    //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
}
