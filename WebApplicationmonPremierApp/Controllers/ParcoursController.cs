using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationmonPremierApp.Models;

namespace WebApplicationmonPremierApp.Controllers
{
    public class ParcoursController : Controller
    {
        public ActionResult Liste()
        {
            // Les actions du controler -- méthode
            return View();
            // ce qui suppos que nous avons une Vue qui s'appelle Liste
            // et qui se trouve dans le rep /Views/parcours
        }
        // index qui route vers une autre Vue

        public ActionResult Index()
        {
            return View("Toto");
        }

        // autre action 

        public ActionResult Rechercher()
        {
            //code
            //

            // En attandant de créer la vue correspondante, on peut retourner vers null
            return null;
        }

        // Action Mon Parcours

        public ActionResult MonParcours()
        {
            // Retourner un Parcours p à ce vue
            Parcours p = new Parcours();
            p.Id = 1;
            p.Nom = "Dot net";
            p.Slogan = "The best";
            p.Logo = "mon logo";
            return View(p);
        }
    }
}