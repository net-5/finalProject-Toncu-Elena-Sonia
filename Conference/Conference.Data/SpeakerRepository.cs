using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISpeakerRepository
    {
        IEnumerable<Speakers> GetAllSpeakers();
        Speakers GetSpeakerById(int id);
        Speakers AddSpeaker(Speakers speakerToAdd);
        Speakers UpdateSpeaker(Speakers speakerToUpdate);
        IEnumerable<Speakers> DeleteSpeaker(Speakers speakerToDelete);
        bool IsUniqueName(string name);
    }
    public class SpeakerRepository:ISpeakerRepository
    {
        private readonly ConferenceContext confContext;
        public SpeakerRepository(ConferenceContext confContext)
        {
            this.confContext = confContext;
        }

        public IEnumerable<Speakers> GetAllSpeakers()
        {
            return confContext.Speakers.ToList();
        }

        public Speakers GetSpeakerById(int id)
        {
            return confContext.Speakers.Find(id);
        }
        public Speakers AddSpeaker(Speakers speakerToAdd)
        {
            var addedEntity = confContext.Speakers.Add(speakerToAdd);
            confContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Speakers UpdateSpeaker(Speakers speakerToUpdate)
        {
            var updateEntity = confContext.Speakers.Update(speakerToUpdate);
            confContext.SaveChanges();
            return updateEntity.Entity;
        }
        public IEnumerable<Speakers> DeleteSpeaker(Speakers speakerToDelete)
        {
            var deleteEntity = confContext.Speakers.Remove(speakerToDelete);
            confContext.SaveChanges();
            return confContext.Speakers.ToList();
        }
        public bool IsUniqueName(string name)
        {
            int number = confContext.Speakers.Count(x => x.CompanyName == name);
            if (number == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
