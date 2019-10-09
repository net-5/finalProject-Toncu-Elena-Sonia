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
    public class SpeakersController : Controller
    {
        private readonly ISpeakerService speakerService;

        public SpeakersController(ISpeakerService speakerService)
        {
            this.speakerService = speakerService;
        }
        // GET: Speakers
        public ActionResult Index()
        {
            IEnumerable<Speakers> allSpeakers = speakerService.GetAllSpeakers();
            return View(allSpeakers);
        }

        // GET: Speakers/Details/5
        public ActionResult Details(int id)
        {
            var getSpeakerById = speakerService.GetSpeakerById(id);
            SpeakerViewModel model = new SpeakerViewModel();
            model.InjectFrom(getSpeakerById);
            return View(model);
        }

        // GET: Speakers/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Speakers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpeakerViewModel model)
        {
            if (ModelState.IsValid)
            {
                Speakers newSpeaker = new Speakers();
                newSpeaker.InjectFrom(model);
                var speakerAdded = speakerService.AddSpeaker(newSpeaker);
                if (speakerAdded == null)
                {
                    ModelState.AddModelError("CompanyName", "Company name must be unique!");
                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Speakers/Edit/5
        public ActionResult Edit(int id)
        {
            var speakerById = speakerService.GetSpeakerById(id);
            SpeakerViewModel model = new SpeakerViewModel();
            model.InjectFrom(speakerById);
            return View(model);
        }

        // POST: Speakers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SpeakerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingSpeaker = speakerService.GetSpeakerById(id);
                if (ModelState.IsValid)
                {
                    TryUpdateModelAsync(existingSpeaker);
                    speakerService.UpdateSpeaker(existingSpeaker);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Speakers/Delete/5
        public ActionResult Delete(int id)
        {
            var existingSpeaker = speakerService.GetSpeakerById(id);
            SpeakerViewModel model = new SpeakerViewModel();
            model.InjectFrom(existingSpeaker);
            return View(model);
        }

        // POST: Speakers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SpeakerViewModel model)
        {
            Speakers speakerToDelete = new Speakers();
            speakerToDelete = speakerService.GetSpeakerById(id);
            model.InjectFrom(speakerToDelete);
            speakerService.DeleteSpeaker(speakerToDelete);
            return RedirectToAction(nameof(Index));
        }
    }
}