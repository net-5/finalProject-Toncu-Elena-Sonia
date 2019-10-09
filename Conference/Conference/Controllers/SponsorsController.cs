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
    public class SponsorsController : Controller
    {
        private readonly ISponsorService sponsorService;


        public SponsorsController(ISponsorService sponsorService)
        {
            this.sponsorService = sponsorService;
        }
        // GET: Sponsors
        public ActionResult Index()
        {
            var getAllSponsors = sponsorService.GetAllSponsors();
            return View(getAllSponsors);
        }

        // GET: Sponsors/Details/5
        public ActionResult Details(int id)
        {
            var getSponsorById = sponsorService.GetSponsorById(id);
            SponsorViewModel model = new SponsorViewModel();
            model.InjectFrom(getSponsorById);
            return View(model);
        }

        // GET: Sponsors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sponsors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorViewModel model)
        {
            if (ModelState.IsValid)
            {
                Sponsors newSponsor = new Sponsors();
                newSponsor.InjectFrom(model);
                var sponsorAdded = sponsorService.AddSponsor(newSponsor);
                if (sponsorAdded == null)
                {
                    ModelState.AddModelError("Name", "Name of sponsor must be unique!");
                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Sponsors/Edit/5
        public ActionResult Edit(int id)
        {
            var sponsorById = sponsorService.GetSponsorById(id);
            SponsorViewModel model = new SponsorViewModel();
            model.InjectFrom(sponsorById);
            return View(model);
        }

        // POST: Sponsors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingSponsor = sponsorService.GetSponsorById(id);
                if (ModelState.IsValid)
                {
                    TryUpdateModelAsync(existingSponsor);
                    sponsorService.UpdateSponsor(existingSponsor);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Sponsors/Delete/5
        public ActionResult Delete(int id)
        {
            var existingSponsor = sponsorService.GetSponsorById(id);
            SponsorViewModel model = new SponsorViewModel();
            model.InjectFrom(existingSponsor);
            return View(model);
        }

        // POST: Sponsors/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorViewModel model)
        {
            Sponsors sponsorToDelete = new Sponsors();
            sponsorToDelete = sponsorService.GetSponsorById(id);
            model.InjectFrom(sponsorToDelete);
            sponsorService.DeleteSponsor(sponsorToDelete);
            return RedirectToAction(nameof(Index));
        }
    }
}