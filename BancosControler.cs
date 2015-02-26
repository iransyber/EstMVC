using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstudoMVCC.EF;
using System.Data.Entity;
using EstudoMVCC.Models;

namespace EstudoMVCC.Controllers
{
    public class BancosController : Controller
    {
        //
        // GET: /Bancos/

        public ActionResult CadastrarBancos(BancosClasse cadBanco)
        {
            var db = new SybertonEntities();
            var Banco = db.Bancos.Create();

            Banco.Nome_Banco = cadBanco.Nome_Banco;

            db.Bancos.Add(Banco);
            db.SaveChanges();
            return View();
        }

    }
}
