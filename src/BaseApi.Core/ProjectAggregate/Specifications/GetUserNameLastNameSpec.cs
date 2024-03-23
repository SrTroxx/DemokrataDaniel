using Ardalis.Specification;
using BaseApi.Core.ProjectAggregate.Entities;

namespace BaseApi.Core.ProjectAggregate.Specifications;

public class GetUserNameLastNameSpec : Specification<Usuarios>
{
  public GetUserNameLastNameSpec(string name, string lastName, int skip, int take)
  {
    Query.Where(a => a.primer_nombre == name || a.segundo_apellido == lastName)
      .Skip(skip)
      .Take(take);
  }
}
