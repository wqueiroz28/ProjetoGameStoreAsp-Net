using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaGames.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaGames.Controllers
{
    public class JogoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Jogo jogo)
        {
            return View();
        }



        public IActionResult Listar()
        {

            return View();
        }


    }
}