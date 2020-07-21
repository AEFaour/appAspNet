using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationmonPremierApp.Models;

namespace WebApplicationmonPremierApp.Controllers
{
    public class IndicateursController : Controller
    {
        private EFParcours db = new EFParcours();

        // GET: Indicateurs
        public async Task<ActionResult> Index()
        {
            return View(await db.Indicateurs.ToListAsync());
        }

        // GET: Indicateurs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indicateur indicateur = await db.Indicateurs.FindAsync(id);
            if (indicateur == null)
            {
                return HttpNotFound();
            }
            return View(indicateur);
        }

        // GET: Indicateurs/Create
        public ActionResult Create()
        {
            ViewBag.IdModule = new SelectList(db.Modules, "id", "Nom");
            return View();
        }

        // POST: Indicateurs/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdIndicateur,Libelle,Valeur,DateEvaluation,IdModule")] IndicateurView indicateur)
        {
            if (ModelState.IsValid)
            {
                Indicateur indic = new Indicateur();
                Module m = new Module();

                Module modeleSelectionne = db.Modules.SingleOrDefault(x => x.id == indicateur.IdModule);
                indic.Libelle = indicateur.Libelle; indic.Module = modeleSelectionne; indic.DateEvaluation = indicateur.DateEvaluation; indic.Valeur = indicateur.Valeur;
                db.Indicateurs.Add(indic);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(indicateur);
        }

        // GET: Indicateurs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indicateur indicateur = await db.Indicateurs.FindAsync(id);
            if (indicateur == null)
            {
                return HttpNotFound();
            }
            return View(indicateur);
        }

        // POST: Indicateurs/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdIndicateur,Libelle,Valeur,DateEvaluation")] Indicateur indicateur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(indicateur).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(indicateur);
        }

        // GET: Indicateurs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indicateur indicateur = await db.Indicateurs.FindAsync(id);
            if (indicateur == null)
            {
                return HttpNotFound();
            }
            return View(indicateur);
        }

        // POST: Indicateurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Indicateur indicateur = await db.Indicateurs.FindAsync(id);
            db.Indicateurs.Remove(indicateur);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
