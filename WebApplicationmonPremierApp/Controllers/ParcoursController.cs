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
        // Les actions du controler -- méthode
        private static List<Parcours> parcours = new List<Parcours>();

        public ActionResult Liste()
        {

            return View(parcours);
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
            // Comment la Vue va utiliser cet objet p
        }
        //Action liste des parcours
        public ActionResult ListeParcours()
        {
            // Créer une liste de parcours
            List<Parcours> _list = new List<Parcours>();
            Random r = new Random();
            int j = 0;
            for (int k = 0; k < 30; k++)
            {
                Parcours p = new Parcours();
                j = r.Next(j, 101);
                p.Id = j;
                p.Nom = "Nom du Parcours" + j;
                p.Slogan = "Slogan du Parcours " + j;
                p.Logo = "Logo du Parcours " + j;
                _list.Add(p);

            }
            return View(_list);
            //Contruire la vue pourquelle affiche la liste
        }
        // Saisie des infos du Parcours
        [HttpPost]
        public ActionResult Saisie(Parcours p)
        {
            parcours.Add(p);
            return View();
        }
        // D'abord le présenter à l'ulisateur pour la saisie
        //get
        public ActionResult Saisie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaisieBootstrap(Parcours p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }
            else
            {
                parcours.Add(p);
                return View();
            }

        }
        public ActionResult SaisieBootstrap()
        {
            return View();
        }

        // Saisie = get (qui renvoie le formulaire) + un poste qui récupère le contenu du formulaire
        public ActionResult SaisieHelperRazor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaisieHelperRazor(Parcours p)
        {
            //Ajouter à la liste
            if (!ModelState.IsValid)
            {
                return View(p);
            }
            else
            {
                parcours.Add(p);
                return View();
            }

        }

        // Modification get suivi de Poste

        public ActionResult ModifParcours(int id)
        {
            Parcours parcoursAModifier = parcours.SingleOrDefault(p => p.Id == id);
            if (parcoursAModifier == null)
            {
                return View("Erreur");
            }
            else
            {
                return View(parcoursAModifier);
            }

            //Suppression Get puis Post
        }
        [HttpPost]
        public ActionResult ModifParcours(Parcours p)
        {

            // Modifier le parcours 
            Parcours AModifier = parcours.SingleOrDefault(x => x.Id == p.Id);
            if (AModifier != null)
            {
                //AModifier.Nom = p.Nom; AModifier.Slogan = p.Slogan; AModifier.Logo = p.Logo;
                parcours.Remove(AModifier); parcours.Add(p); // puisque la liste est static: Modif = Supp +Ajout
            }

            return
                View("Liste", parcours);


        }

        //Suppression Get puis Post
    }

}