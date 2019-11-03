using LojaVirtual.Dominio.Interfaces;
using LojaVirtual.Dominio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtualAspNetCore3.Web.Controllers
{
   
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepositorio.ObterTodos());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
               
                _produtoRepositorio.Adicionar(produto);
                return Created("api/produto", produto);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
