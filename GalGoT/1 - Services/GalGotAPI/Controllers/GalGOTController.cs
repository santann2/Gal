using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GalGOT.Domain.Entites;
using GalGOT.Aplication.Interface;
using Microsoft.AspNetCore.Cors;

namespace GalGotAPI.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class GalGOTController : ControllerBase
    {
        private readonly IGalGOTAppService _galGOTAppService;

        public GalGOTController(IGalGOTAppService galGOTAppService)
        {
            _galGOTAppService = galGOTAppService;
        }

        [HttpPost("Listar")]
        public ActionResult<IEnumerable<Casa>> Listar()
        {
            var response = _galGOTAppService.SelecionarTudo();
            return response;
        }

        [HttpPost("ListarId")]
        public ActionResult<Casa> Listar(int id)
        {
            var response = _galGOTAppService.SelecionarPorId(id);
            return response;
        }

        [HttpPost("Incluir")]
        public void Incluir([FromBody] Casa request)
        {
            _galGOTAppService.Incluir(request);
        }

        [HttpPost("Editar")]
        public void Editar([FromBody] Casa request)
        {
            _galGOTAppService.Alterar(request);
        }

        [HttpPost("Excluir")]
        public void Excluir(int id)
        {
            _galGOTAppService.Excluir(id);
        }
    }
}
