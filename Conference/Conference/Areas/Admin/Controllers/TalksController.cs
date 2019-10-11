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
    public class TalksController : Controller
    {
        private readonly ITalkService talkService;
        private readonly IEditionService editionService;
        private readonly ISpeakerService speakerService;

        public TalksController(ITalkService talkService)
        {
            this.talkService = talkService;
        }
        // GET: Talks
        public ActionResult Index()
        {
            var allTalks = talkService.GetAllTalks();
            return View(allTalks);
        }

        // GET: Talks/Details/5
        public ActionResult Details(int id)
        {
            var talkById = talkService.GetTalkById(id);
            TalkViewModel model = new TalkViewModel();
            model.InjectFrom(talkById);
            return View(model);
        }

        // GET: Talks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Talks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TalkViewModel model)
        {
            if (ModelState.IsValid)
            {  
                Talks newTalk = new Talks();
                newTalk.InjectFrom(model);
                var talkAdded = talkService.AddTalk(newTalk);
                if (talkAdded == null)
                {
                    ModelState.AddModelError("Name", "The Name of the talk must be unique!");
                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Talks/Edit/5
        public ActionResult Edit(int id)
        {
            var talkById = talkService.GetTalkById(id);
            TalkViewModel model = new TalkViewModel();
            model.InjectFrom(talkById);
            return View(model);
           
        }

        // POST: Talks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TalkViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingTalk = talkService.GetTalkById(id);
                if (ModelState.IsValid)
                {
                    TryUpdateModelAsync(existingTalk);
                    talkService.UpdateTalk(existingTalk);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Talks/Delete/5
        public ActionResult Delete(int id)
        {
            var existingTalk = talkService.GetTalkById(id);
            TalkViewModel model = new TalkViewModel();
            model.InjectFrom(existingTalk);
            return View(model);
        }

        // POST: Talks/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TalkViewModel model)
        {
            Talks talkToDelete = new Talks();
            talkToDelete = talkService.GetTalkById(id);
            model.InjectFrom(talkToDelete);
            talkService.DeleteTalk(talkToDelete);
            return RedirectToAction(nameof(Index));

        }
    }
}