﻿using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using LojaVirtual.Repositories.Contracts;
using LojaVirtual.Libraries.Filtro;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class HomeController : Controller
    {
        private IColaboradorRepository _repositoryColaborador;
        private LoginColaborador _loginColaborador;
        public HomeController(IColaboradorRepository repositoryColaborador, LoginColaborador loginColaborador) 
        { 
            _repositoryColaborador= repositoryColaborador;
            _loginColaborador= loginColaborador;
        
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm]Models.Colaborador colaborador)
        {
            Models.Colaborador colaboradorDB = _repositoryColaborador.Login(colaborador.Email, colaborador.Senha);

            if (colaboradorDB != null)
            {
                _loginColaborador.Login(colaboradorDB);

                return new RedirectResult(Url.Action(nameof(Painel)));
            }
            else
            {
                ViewData["MSG_E"] = "Usuário não encontrado, verifique o e-mail e senha digitado!";
                return View();
            }
           
        }
        [ColaboradorAutorizacao]
        public IActionResult Logout()
        {
            _loginColaborador.Logout();
            return RedirectToAction("Login", "Home");
        }

        public IActionResult RecuperarSenha()
        {
            return View();

        }
        public IActionResult CadastrarNovaSenha()
        {
            return View();
        }


        [ColaboradorAutorizacao]
        public IActionResult Painel()
        {

            return View();

        }
    }
}
