using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISponsorRepository
    {
        IEnumerable<Sponsors> GetAllSponsors();
        Sponsors GetSponsorById(int id);
        Sponsors AddSponsor(Sponsors sponsorToAdd);
        Sponsors UpdateSponsor(Sponsors sponsorToUpdate);
        IEnumerable<Sponsors> DeleteSponsor(Sponsors sponsorToDelete);
        bool IsUniqueName(string name);
    }
    public class SponsorRepository : ISponsorRepository
    {
        private readonly ConferenceContext conferenceContext;
        public SponsorRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }
        public IEnumerable<Sponsors> GetAllSponsors()
        {
            return conferenceContext.Sponsors.ToList();
        }

        public Sponsors GetSponsorById(int id)
        {
            return conferenceContext.Sponsors.Find(id);
        }
        public Sponsors AddSponsor(Sponsors sponsorToAdd)
        {
            var addEntity = conferenceContext.Sponsors.Add(sponsorToAdd);
            conferenceContext.SaveChanges();
            return addEntity.Entity;
        }
        public Sponsors UpdateSponsor(Sponsors sponsorToUpdate)
        {
            var updateEntity = conferenceContext.Sponsors.Update(sponsorToUpdate);
            conferenceContext.SaveChanges();
            return updateEntity.Entity;
        }
        public IEnumerable<Sponsors> DeleteSponsor(Sponsors sponsorToDelete)
        {
            var deleteEntity = conferenceContext.Sponsors.Remove(sponsorToDelete);
            conferenceContext.SaveChanges();
            return conferenceContext.Sponsors.ToList();
        }
        public bool IsUniqueName(string name)
        {
            int number = conferenceContext.Sponsors.Count(x => x.Name == name);
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
