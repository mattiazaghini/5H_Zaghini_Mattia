using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _5H_Zaghini_Mattia.Models;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace _5H_Zaghini_Mattia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        } 
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Authorize]
        [HttpPost]
        public IActionResult AggiungiCond(Condominio a)
        {
            var db=new DBContext(); 
            db.Condomini.Add(a);
            db.SaveChanges();
            return View("Elenco", db);
        }

        [HttpGet]
        public IActionResult Cancella( int id)
        {
            var db = new DBContext();
            Condominio aggiunge=db.Condomini.Find(id);
            if(aggiunge!=null)
            {
            db.Remove(aggiunge);
            db.SaveChanges();
            return View("Elenco", db);
            }
            else
            {
                return NotFound();
            }
            
        }

        //[Authorize]
        [HttpGet]
         public IActionResult Elenco()
        {
            var db= new DBContext();
            return View(db);
        }

        [HttpGet]
         public IActionResult Modifica(int Id)
        {
            var db = new DBContext();
            Condominio aggiunge=db.Condomini.Find(Id);
            if(aggiunge!=null)
            {
                return View("Modifica",aggiunge);
            }
            else
            {
                return NotFound();                
            }
        }
        [HttpPost]
        public IActionResult Modifica(int id,Condominio nuovo)
        {
            var db = new DBContext();
            var vecchio=db.Condomini.Find(id);
            if(vecchio!=null)
            {
                vecchio.Nome=nuovo.Nome;
                vecchio.Piani=nuovo.Piani;
                db.Condomini.Update(vecchio);
                db.SaveChanges();
            }
            return View("Elenco",db);
        }
        public IActionResult CancellaTutto()
        {   
            var db=new DBContext();
            db.RemoveRange(db.Condomini);
            db.SaveChanges();
            return View("Elenco",db);
        }    

        //[Authorize]
        [HttpGet] 
        public IActionResult UnitaImm(int Id)
        {
            var db= new DBContext();
            Condominio aggiunge=db.Condomini.Find(Id);

            if(aggiunge!=null)
            {
                AggiungeUnitaImm Unita= db.AggiungiUnitaImm.Find(aggiunge.CondominioId);
                return View("UnitaImm",Unita);
            }
            else
            {
                return NotFound();
            }
            
        }


        [HttpGet] 
        public IActionResult AggiungiAlloggio(int Id)
        {
            var db= new DBContext();
            Condominio aggiunge=db.Condomini.Find(Id);

            if(aggiunge!=null)
            {
                AggiungeUnitaImm Unita= db.AggiungiUnitaImm.Find(aggiunge.CondominioId);
                return View("AggiungiUnitaImm",Unita);
            }
            else
            {
                return NotFound();
            }
            
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult AggiungiCond()
        {
            return View();
        }
    }
}
