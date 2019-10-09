using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISponsorTypeRepository
    {
        IEnumerable<SponsorTypes> GetAllSponsorTypes();
        SponsorTypes GetSponsorTypeById(int id);
        SponsorTypes AddSponsorType(SponsorTypes sponsorTypeToAdd);
        SponsorTypes UpdateSponsor(SponsorTypes sponsorTypeToUpdate);
        IEnumerable<SponsorTypes> DeleteSponsorType(SponsorTypes sponsorTypeToDelete);
        bool IsUniqueName(string name);
    }
    public class SponsorTypeRepository : ISponsorTypeRepository
    {
        private readonly ConferenceContext conferenceContext;
        public SponsorTypeRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }
        public IEnumerable<SponsorTypes> GetAllSponsorTypes()
        {
            return conferenceContext.SponsorTypes.ToList();
        }
        public SponsorTypes GetSponsorTypeById(int id)
        {
            return conferenceContext.SponsorTypes.Find(id);
        }

        public SponsorTypes AddSponsorType(SponsorTypes sponsorTypeToAdd)
        {
            var addEntity = conferenceContext.SponsorTypes.Add(sponsorTypeToAdd);
            conferenceContext.SaveChanges();
            return addEntity.Entity;
        }
        public SponsorTypes UpdateSponsor(SponsorTypes sponsorTypeToUpdate)
        {
            var updateEntity = conferenceContext.SponsorTypes.Update(sponsorTypeToUpdate);
            conferenceContext.SaveChanges();
            return updateEntity.Entity;
        }
        public IEnumerable<SponsorTypes> DeleteSponsorType(SponsorTypes sponsorTypeToDelete)
        {
            var deleteEntity = conferenceContext.SponsorTypes.Remove(sponsorTypeToDelete);
            conferenceContext.SaveChanges();
            return conferenceContext.SponsorTypes.ToList();
        }     
        public bool IsUniqueName(string name)
        {
            int number = conferenceContext.SponsorTypes.Count(x => x.Name == name);
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
