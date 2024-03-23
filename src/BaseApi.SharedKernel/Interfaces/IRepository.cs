using Ardalis.Specification;

namespace BaseApi.SharedKernel.Interfaces
{
  // from Ardalis.Specification
  public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
  {
  }
}
