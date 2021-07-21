using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirtsAPIController : ControllerBase
    {
        private static string nome;

        [HttpGet]
        [Route("get")]
        public ActionResult Get()
        {
            DateTime data = DateTime.Now;
            return BadRequest(data + " - Olá, " + nome);
        }


        [HttpPost]
        [Route("post")]
        public void Post(string entrada)
        {
            nome = entrada;   
        }

        

    }

    



}
