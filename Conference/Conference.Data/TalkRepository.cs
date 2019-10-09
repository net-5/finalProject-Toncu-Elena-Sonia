using Conference.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ITalkRepository
    {
        IEnumerable<Talks> GetAllTalks();
        Talks GetTalkById(int id);
        Talks AddTalk(Talks talkToAdded);
        Talks UpdateTalk(Talks talkToUpdate);
        IEnumerable<Talks> DeleteTalk(Talks talkToDelete);
        bool IsUniqueName(string name);
    }
    public class TalkRepository:ITalkRepository
    {
        private readonly ConferenceContext conferenceContext;
        public TalkRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public IEnumerable<Talks> GetAllTalks()
        {
            //return conferenceContext.Talks.ToList();
            return conferenceContext.Talks.Include(x => x.Speaker).ToList();
        }

        public Talks GetTalkById(int id)
        {
            var talkById = conferenceContext.Talks.Find(id);
            return talkById;
        }
        public Talks AddTalk(Talks talkToAdded)
        {
            var entityAdded = conferenceContext.Talks.Add(talkToAdded);
            conferenceContext.SaveChanges();
            return entityAdded.Entity;
        }

        public Talks UpdateTalk(Talks talkToUpdate)
        {
            var updateEntity = conferenceContext.Talks.Update(talkToUpdate);
            conferenceContext.SaveChanges();
            return updateEntity.Entity;
        }

        public IEnumerable<Talks> DeleteTalk(Talks talkToDelete)
        {
            var deletedEntity = conferenceContext.Talks.Remove(talkToDelete);
            conferenceContext.SaveChanges();
            return conferenceContext.Talks.ToList();           
        }

        public bool IsUniqueName(string name)
        {
            int number = conferenceContext.Talks.Count(x => x.Name == name);
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
