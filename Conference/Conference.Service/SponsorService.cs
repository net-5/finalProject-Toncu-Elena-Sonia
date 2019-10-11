using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISponsorService
    {
        IEnumerable<Sponsors> GetAllSponsors();
        Sponsors GetSponsorById(int id);
        Sponsors AddSponsor(Sponsors sponsorToAdd);
        Sponsors UpdateSponsor(Sponsors sponsorToUpdate);
        IEnumerable<Sponsors> DeleteSponsor(Sponsors sponsorToDelete);
        bool IsUniqueName(string name);
    }
    public class SponsorService : ISponsorService
    {
        private readonly ISponsorRepository sponsorRepository;
        public SponsorService(ISponsorRepository sponsorRepository)
        {
            this.sponsorRepository = sponsorRepository;
        }
        public IEnumerable<Sponsors> GetAllSponsors()
        {
            return sponsorRepository.GetAllSponsors();
        }
        public Sponsors GetSponsorById(int id)
        {
            var getSponsorById = sponsorRepository.GetSponsorById(id);
            return getSponsorById;
        }
        public Sponsors AddSponsor(Sponsors sponsorToAdd)
        {
            if (IsUniqueName(sponsorToAdd.Name))
            {
                return sponsorRepository.AddSponsor(sponsorToAdd);
            }
            return null;
        }
        public Sponsors UpdateSponsor(Sponsors sponsorToUpdate)
        {
            var updateSponsor=sponsorRepository.UpdateSponsor(sponsorToUpdate);
            return updateSponsor;
        }
        public bool IsUniqueName(string name)
        {
            return sponsorRepository.IsUniqueName(name);
        }
        public IEnumerable<Sponsors> DeleteSponsor(Sponsors sponsorToDelete)
        {
           sponsorRepository.DeleteSponsor(sponsorToDelete);
            return sponsorRepository.GetAllSponsors();
        }

    }
}
