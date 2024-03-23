using BaseApi.Api.Controllers.Api;
using BaseApi.Core.Interfaces;
using BaseApi.Core.ProjectAggregate.DTO;
using BaseApi.Core.ProjectAggregate.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks;

namespace BaseApi.Api.Controllers;

public class UsuariosController : BaseApiController
{
  public readonly IUsuariosService _usuarioservice;

  public UsuariosController(IUsuariosService clienteService)
  {
    _usuarioservice = clienteService;
  }

  [HttpGet("GetAllUsuario")]
  [ProducesResponseType(StatusCodes.Status201Created)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> GetAllUsuarios()
  {
    try
    {
      var result = await _usuarioservice.GetAllUsuarios();
      return Ok(result);
    }
    catch (Exception ex)
    {
      return StatusCode(201, ex.Message.ToString());
    }
  }

  [HttpGet("Usuario/Id")]
  [ProducesResponseType(StatusCodes.Status201Created)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> GetByIdUsuarios(int Id)
  {
    try
    {
      var result = await _usuarioservice.GetByIdUsuarios(Id);
      if (result == null)
      {
        return NotFound("Usuario no Encontrado");
      }
      return Ok(result);
    }
    catch (Exception ex)
    {
      return StatusCode(201, ex.Message.ToString());
    }
  }

  [HttpGet("GetUsuarioForNameAndLastName")]
  [ProducesResponseType(StatusCodes.Status201Created)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> GetUserNameLastName(string primer_nombre, string segundo_apellido, int Desde, int Hasta)
  {
    try
    {
      var result = await _usuarioservice.GetUserNameLastName(primer_nombre, segundo_apellido, Desde, Hasta);
      return Ok(result);
    }
    catch (Exception ex)
    {
      return StatusCode(201, ex.Message.ToString());
    }
  }

  [HttpPost("CreateUsuario")]
  [ProducesResponseType(StatusCodes.Status201Created)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> CreateClient(UsuariosDTO usuarios)
  {
    try
    {
      var result = await _usuarioservice.CreateUsuarios(usuarios);
      return Ok(result);
    }
    catch (Exception ex)
    {
      return StatusCode(201, ex.Message.ToString());
    }
  }


  [HttpDelete("DeleteUsuario")]
  [ProducesResponseType(StatusCodes.Status201Created)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> DeleteUsuarios(int IdUsuario)
  {
    try
    {
      await _usuarioservice.DeleteUsuarios(IdUsuario);
      return Ok("Usuario Eliminado Correctamente");
    }
    catch (Exception ex)
    {
      return StatusCode(201, ex.Message.ToString());
    }
  }

  [HttpPut("UpdateUsuario")]
  [ProducesResponseType(StatusCodes.Status201Created)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> UpdateUsuarios(UsuariosDTO usuarios)
  {
    try
    {
      await _usuarioservice.UpdateUsuarios(usuarios);
      return Ok("Usuario Eliminado Correctamente");
    }
    catch (Exception ex)
    {
      return StatusCode(201, ex.Message.ToString());
    }
  }
}
