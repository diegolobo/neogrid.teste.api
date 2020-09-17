using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace neogrid.teste.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NeogridController : ControllerBase
    {
        private const double TAXA_JURO = 0.01;

        [HttpGet("taxaJuros")]
        public String Index()
        {
            return $"{TAXA_JURO}%";
        }

        [HttpGet("calculajuros")]
        public String CalcularJuros(decimal valorInicial, int tempo)
        {
            if (tempo < 1)
                return 0.ToString();

            valorInicial = valorInicial * (decimal)Math.Pow(TAXA_JURO + 1, tempo);

            return valorInicial.ToString("F");
        }

        [HttpGet("showmethecode")]
        public String ShowMeTheCode()
        {
            return "https://github.com/diegolobo/neogrid.teste.api";
        }
    }
}
