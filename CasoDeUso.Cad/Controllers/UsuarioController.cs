

using CasoDeUso.Cad.Models;
using CasoDeUso.Cad.Models.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CasoDeUso.Cad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuario<Usuario> _repository;

        public UsuarioController(IUsuario<Usuario> repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<string>> ObterTodos()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Obter(int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpPost("")]
        public ActionResult Cadastrar([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario == null) return BadRequest();

                _repository.Add(usuario);
                return Ok("Cliente encontrado com sucesso");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Usuario usuario)
        {
            try
            {
                if (usuario == null) return BadRequest();

                if (usuario.id != id) return BadRequest();

               _repository.Update(usuario);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id, Usuario usuario)
        {
            try
            {
                if (_repository == null)
                    return NotFound();

                _repository.Remover(usuario);
                return Ok("Cliente removido com sucesso");

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
