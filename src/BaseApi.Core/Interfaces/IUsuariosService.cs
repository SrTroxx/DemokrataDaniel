using System.Xml.Linq;
using BaseApi.Core.ProjectAggregate.DTO;
using BaseApi.Core.ProjectAggregate.Entities;

namespace BaseApi.Core.Interfaces
{
  public interface IUsuariosService
  {
    Task<Usuarios> GetByIdUsuarios(int Id);

    Task<List<Usuarios>> GetAllUsuarios();

    Task<UsuariosDTO> CreateUsuarios(UsuariosDTO usuariosDTO);

    Task DeleteUsuarios(int Id);

    Task UpdateUsuarios(UsuariosDTO usuarios);

    Task<List<Usuarios>> GetUserNameLastName(string name, string lastName, int skip, int take);
  }
}
