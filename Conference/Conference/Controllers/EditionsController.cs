using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Domain.Entities;
using Conference.Models;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Controllers
{
    public class EditionsController : Controller
    {
        private IEditionService editionService;
        public EditionsController(IEditionService editionService)
        {
            this.editionService = editionService;
        }
        // GET: Editions
        public ActionResult Index()
        {
            IEnumerable<Editions> allEditions = editionService.GetAllEditions();
            return View(allEditions);
        }

        // GET: Editions/Details/5
        public ActionResult Details(int id)
        {
            var getById = editionService.GetElementById(id);

            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(getById);
            return View(model);
        }

        // GET: Editions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Editions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditionViewModel model)
        {
            if (ModelState.IsValid)
            {
                Editions editionToAdd = new Editions();
                editionToAdd.InjectFrom(model);
                var addedEdition = editionService.AddEdition(editionToAdd);
                if (addedEdition == null)
                {
                    ModelState.TryAddModelError("Name", "The Name must be unique!");
                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Editions/Edit/5
        public ActionResult Edit(int id)
        {
            var editionEdit = editionService.GetElementById(id);
            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(editionEdit);
            return View(model);
        }

        // POST: Editions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditionViewModel model)
        {
            if (ModelState.IsValid)
            {
                //find the edition to update (if exists)
                var existingEdition = editionService.GetElementById(id);

                if (ModelState.IsValid)
                {
                    //update the existing db entity with the change from the model    
                    TryUpdateModelAsync(existingEdition);

                    //update and save the changes into the db
                    editionService.UpdateEdition(existingEdition);
                    //redirect to Index, because everything went ok
                    return RedirectToAction(nameof(Index));
                }
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            else
            {
                //re-return the view to display errors
                return View(model);
            }
        }

        // GET: Editions/Delete/5
        public ActionResult Delete(int id)
        {
            var existingEdition = editionService.GetElementById(id);
            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(existingEdition);
            return View(model);
        }

        // POST: Editions/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EditionViewModel model)
        {
            Editions editionToDelete = new Editions();
            editionToDelete = editionService.GetElementById(id);
            model.InjectFrom(editionToDelete);
            editionService.DeleteEdition(editionToDelete);
            return RedirectToAction(nameof(Index));

        }
    }
}