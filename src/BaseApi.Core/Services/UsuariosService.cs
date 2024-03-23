
using Ardalis.Specification;
using BaseApi.Core.Interfaces;
using BaseApi.Core.ProjectAggregate.DTO;
using BaseApi.Core.ProjectAggregate.Entities;
using BaseApi.Core.ProjectAggregate.Specifications;
using BaseApi.SharedKernel.Interfaces;

namespace BaseApi.Core.Services
{
  public class UsuariosService : IUsuariosService
  {
    public readonly IRepository<Usuarios> _repository;

    public UsuariosService(IRepository<Usuarios> repository)
    {
      _repository = repository;
    }

    public async Task<Usuarios> GetByIdUsuarios(int Id)
    {
      return await _repository.GetByIdAsync(Id);
    }

    public async Task<List<Usuarios>> GetAllUsuarios()
    {
      return await _repository.ListAsync();
    }

    public async Task<UsuariosDTO> CreateUsuarios(UsuariosDTO usuariosDTO)
    {
      Usuarios usuariosEntity = new Usuarios();
      usuariosEntity.primer_nombre = usuariosDTO.primer_nombre;
      usuariosEntity.segundo_nombre = usuariosDTO.segundo_nombre;
      usuariosEntity.primer_apellido = usuariosDTO.primer_apellido;
      usuariosEntity.segundo_apellido = usuariosDTO.segundo_apellido;
      usuariosEntity.fecha_nacimiento = usuariosDTO.fecha_nacimiento;

      if (usuariosDTO.sueldo == 0)
      {
        throw new Exception("El valor del Sueldo debe ser Mayor a Cero");
      }
      else
      {
        usuariosEntity.sueldo = usuariosDTO.sueldo;
      }
      usuariosEntity.fecha_creacion = DateTime.Now;      

      await _repository.AddAsync(usuariosEntity);
      return usuariosDTO;
    }
    public async Task DeleteUsuarios(int Id)
    {
      await _repository.DeleteAsync(await _repository.GetByIdAsync(Id));
    }

    public async Task UpdateUsuarios(UsuariosDTO usuariosDTO)
    {

      Usuarios usuariosEntity = new Usuarios();
      usuariosEntity.primer_nombre = usuariosDTO.primer_nombre;
      usuariosEntity.segundo_nombre = usuariosDTO.segundo_nombre;
      usuariosEntity.primer_apellido = usuariosDTO.primer_apellido;
      usuariosEntity.segundo_apellido = usuariosDTO.segundo_apellido;
      usuariosEntity.fecha_nacimiento = usuariosDTO.fecha_nacimiento;

      if (usuariosDTO.sueldo == 0)
      {
        throw new Exception("El valor del Sueldo debe ser Mayor a Cero");
      }
      else
      {
        usuariosEntity.sueldo = usuariosDTO.sueldo;
      }
      usuariosEntity.fecha_modificacion = DateTime.Now.ToString();

      await _repository.UpdateAsync(usuariosEntity);
    }

    public async Task<List<Usuarios>> GetUserNameLastName(string name, string lastName, int skip, int take)
    {
      var sc = new GetUserNameLastNameSpec(name, lastName, skip, take);      
      return await _repository.ListAsync(sc);      
    }
  }
}
