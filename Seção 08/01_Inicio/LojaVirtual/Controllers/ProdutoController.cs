﻿using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        /*ActionResult or IActionResult*/
        public ActionResult Visualizar()
        {

            Produto  produto = GetProduto();

            return View(produto);
            //return new ContentResult() { Content = "<h3>Produto -> Visualizar <h3", ContentType = "text/html"};
        }

       private Produto GetProduto()//instanciando e passando os parametros 
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Xbox One X",
                Descricao = "Jogue em 4K",
                Valor = 2000.00M

            };
        }
    }
}
 