using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Conference.Domain.Entities;
using Conference.Models;
using Conference.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Controllers
{
    public class SpeakersController : Controller
    {
        private readonly ISpeakerService speakerService;
        private readonly ConferenceContext conferenceContext;
        private readonly IHostingEnvironment environment;

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
            var speakers = speakerService.GetAllSpeakers();
            ViewBag.Speakers = speakers;
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
        //public IActionResult GetImage(int speakerId)
        //{
        //    Photos requestedPhoto = conferenceContext.Photos.FirstOrDefault(p => p.SpeakerId == speakerId);
        //    if (requestedPhoto != null)
        //    {
        //        string webRootpath = environment.WebRootPath;
        //        string folderPath = "\\img\\";
        //        string fullPath = webRootpath + folderPath + requestedPhoto.Url;

        //        FileStream fileOnDisk = new FileStream(fullPath, FileMode.Open);
        //        byte[] fileBytes;
        //        using (BinaryReader br = new BinaryReader(fileOnDisk))
        //        {
        //            fileBytes = br.ReadBytes((int)fileOnDisk.Length);
        //        }
        //        return File(fileBytes, requestedPhoto.Name);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

    }
}