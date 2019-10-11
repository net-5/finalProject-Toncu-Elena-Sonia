using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Data;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SponsorTypesController : Controller
    {
        private readonly ISponsorTypeService sponsorTypeService;
        private readonly IEditionService editionService;

        public SponsorTypesController(ISponsorTypeService sponsorTypeService,IEditionService editionService)
        {
            this.sponsorTypeService = sponsorTypeService;
            this.editionService = editionService;
        }
        // GET: SponsorTypes
        public ActionResult Index()
        {
            var getAllSponsorTypes = sponsorTypeService.GetAllSponsorTypes();
            return View(getAllSponsorTypes);
        }

        // GET: SponsorTypes/Details/5
        public ActionResult Details(int id)
        {
            var getSponsorTypeById = sponsorTypeService.GetSponsorTypeById(id);
            SponsorTypeViewModel model = new SponsorTypeViewModel();
            model.InjectFrom(getSponsorTypeById);
            return View(model);
        }

        // GET: SponsorTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SponsorTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                SponsorTypes newSponsorType = new SponsorTypes();
                newSponsorType.InjectFrom(model);
                var sponsorTypeAdded = sponsorTypeService.AddSponsorType(newSponsorType);
                if (sponsorTypeAdded==null)
                {
                    ModelState.AddModelError("Name", "Name of sponsor must be unique!");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: SponsorTypes/Edit/5
        public ActionResult Edit(int id)
        {
            var sponsorTypeById = sponsorTypeService.GetSponsorTypeById(id);
            SponsorTypeViewModel model = new SponsorTypeViewModel();
            model.InjectFrom(sponsorTypeById);
            return View(model);
        }

        // POST: SponsorTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingSponsorType = sponsorTypeService.GetSponsorTypeById(id);
                if (ModelState.IsValid)
                {
                    TryUpdateModelAsync(existingSponsorType);
                    sponsorTypeService.UpdateSponsorType(existingSponsorType);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: SponsorTypes/Delete/5
        public ActionResult Delete(int id)
        {
            var existingSponsorType = sponsorTypeService.GetSponsorTypeById(id);
            SponsorTypeViewModel model = new SponsorTypeViewModel();
            model.InjectFrom(existingSponsorType);
            return View(model);
        }

        // POST: SponsorTypes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorTypeViewModel model)
        {
            SponsorTypes sponsorTypeToDelete = new SponsorTypes();
            sponsorTypeToDelete = sponsorTypeService.GetSponsorTypeById(id);
            model.InjectFrom(sponsorTypeToDelete);
            sponsorTypeService.DeleteSponsorType(sponsorTypeToDelete);
            return RedirectToAction(nameof(Index));
        }
    }
}