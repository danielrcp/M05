using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M05.Controllers
{
    public class ProgramaController : Controller
    {
        // GET: Programa
        public ActionResult Index()
        {
            var Context = new M05.Models.SaludMovilEntities();
            var Programas = Context.sm_Programa.ToList();
            return View(Programas);
        }

        public ActionResult Display(int Id)
        {
            var Context = new M05.Models.SaludMovilEntities();
            var Programa = Context.sm_Programa.Find(Id);
            return View("DynamicView",Programa);
        }

        public ActionResult DisplayExtern(int Id)
        {
            var Extern = new Models.ProgramaExterno
            {
                ExternID = 1,
                idPrograma = 2
            };
            return View("DynamicView", Extern);
        }
    }
}