using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkshopsController : Controller
    {
        private readonly IWorkshopService workshopService;

        public WorkshopsController(IWorkshopService workshopService)
        {
            this.workshopService = workshopService;
        }
        // GET: Workshops
        public ActionResult Index()
        {
            var allWorkshops = workshopService.GetAllWorkshops();
            return View(allWorkshops);
        }
        
        // GET: Workshops/Details/5
        public ActionResult Details(int id)
        {
            var getWorkshopById = workshopService.GetWorkShopById(id);
            WorkshopViewModel model = new WorkshopViewModel();
            model.InjectFrom(getWorkshopById);
            return View(model);
        }

        // GET: Workshops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workshops/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( WorkshopViewModel model)
        { 
            if (ModelState.IsValid)
            {
                Workshops newWorkshop = new Workshops();
                newWorkshop.InjectFrom(model);
                var workshopAdded = workshopService.AddWorkshop(newWorkshop);
                if (workshopAdded == null)
                {
                    ModelState.AddModelError("Name", "The Name of the talk must be unique!");
                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Workshops/Edit/5
        public ActionResult Edit(int id)
        {  
            var existingWorkshop = workshopService.GetWorkShopById(id);
            var model = new WorkshopViewModel();
            model.InjectFrom(existingWorkshop);
            return View(model);
        }

        // POST: Workshops/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WorkshopViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingWorkshop = workshopService.GetWorkShopById(id);
                if (ModelState.IsValid)
                {
                    TryUpdateModelAsync(existingWorkshop);
                    workshopService.UpdateWorkshop(existingWorkshop);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Workshops/Delete/5
        public ActionResult Delete(int id)
        {
            var existingWorkshop = workshopService.GetWorkShopById(id);
            WorkshopViewModel model = new WorkshopViewModel();
            model.InjectFrom(existingWorkshop);
            return View(model);
        }

        // POST: Workshops/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, WorkshopViewModel model)
        {
            Workshops workshopToDelete = new Workshops();
            workshopToDelete = workshopService.GetWorkShopById(id);
            model.InjectFrom(workshopToDelete);
            workshopService.DeleteWorkshop(workshopToDelete);
            return RedirectToAction(nameof(Index));
        }
    }
}