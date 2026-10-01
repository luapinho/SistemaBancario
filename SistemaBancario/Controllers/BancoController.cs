using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace SistemaBancario.Controllers
{
    public class BancoController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string tipoAcesso, string senha, string numeroConta)  //Por que de dois login: um é o get(Pega) e outro post(Mandar)
        {
            return View();
        }

        [HttpGet]
        public IActionResult MinhaConta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RealizarTransacao()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PainelGerente()
        {
            return View();
        }
    }
}
