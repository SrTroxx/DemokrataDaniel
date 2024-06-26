﻿using Ardalis.Specification;

namespace BaseApi.SharedKernel.Interfaces
{
  public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
  {
  }
}
