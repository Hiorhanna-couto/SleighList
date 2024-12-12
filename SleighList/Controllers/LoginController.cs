using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.Extensions.Logging;
using SleighList.Contexts;
using SleighList.Models;

namespace SleighList.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        Context context = new Context ();



        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]

        public IActionResult Logar (IFormCollection form ){
            string emailInformado = form["Email"].ToString();
            string senhaInformada = form["Senha"].ToString();

            Usuario usuarioBuscado = context.Usuario.FirstOrDefault(usuario => usuario.Email == emailInformado && usuario.Senha == senhaInformada)!;

            if(usuarioBuscado == null){
                Console.WriteLine($"Dados invalidos");
                return LocalRedirect("~/Login");
            }else{
                Console.WriteLine($"Você entrou !!!");
                HttpContext.Session.SetString("UsuarioID", usuarioBuscado.UsuarioID.ToString());
                return LocalRedirect("~/Login");
            }
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}