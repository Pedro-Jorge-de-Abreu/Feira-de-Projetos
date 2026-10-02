using FeiradeProjetosApi.Models;
using FeiradeProjetosApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FeiradeProjetosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly IFeiradeProjetosRepository _feiradeprojetosRepository;

        public ProjetosController(IFeiradeProjetosRepository feiradeprojetosRepository)
        {
            _feiradeprojetosRepository = feiradeprojetosRepository;
        }

        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar([FromBody] Projeto projeto)
        {
            var resultado = _feiradeprojetosRepository.ObterPorNumero(projeto.NumeroProjeto);

            if (resultado == null)
            {
                _feiradeprojetosRepository.Cadastrar(projeto);
                return Ok("Cadastrado com sucesso");
            }

            return BadRequest("Número do projeto já existe");
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult listar()
        {
            return Ok(_feiradeprojetosRepository.ObterTodos());
        }

        [HttpPost]
        [Route("RegistrarVisita")]
        public IActionResult RegistrarVisita([FromBody] Visita visita)
        {
            var projeto = _feiradeprojetosRepository.ObterPorNumero(visita.NumeroProjeto);
            if (projeto == null)
            {
                return BadRequest("Projeto não encontrado.");
            }

            visita.DataVisita = DateTime.Now;
            _feiradeprojetosRepository.RegistrarVisita(visita);

            return Ok("Visita registrada com sucesso!");
        }
        [HttpGet]
        [Route("ConsultarVisitas/{numero}")]
        public IActionResult ConsultarVisitas(int numero)
        {
                        var projeto = _feiradeprojetosRepository.ObterPorNumero(numero);
            if (projeto == null)
            {
                return NotFound("Projeto não encontrado.");
            }

                        var visitas = _feiradeprojetosRepository.ObterVisitasPorProjeto(numero);

            return Ok(visitas);
        }
    }
}