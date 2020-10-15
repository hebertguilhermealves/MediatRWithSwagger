
using Clientes.Api.Application.Commands;
using Core.Mediator;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Clientes.Api.Controllers
{
    public class ClienteController : ControllerBase
    {
        private readonly IMediatorHandler _mediatorHandler;
        public ClienteController(IMediatorHandler mediatorHandle)
        {
            _mediatorHandler = mediatorHandle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var resultado = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Eduardo", "edu@edu.com", "30314299076"));

            return Ok(resultado);
        }

    }
}
