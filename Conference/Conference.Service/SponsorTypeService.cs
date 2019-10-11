using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISponsorTypeService
    {
        IEnumerable<SponsorTypes> GetAllSponsorTypes();
        SponsorTypes GetSponsorTypeById(int id);
        SponsorTypes AddSponsorType(SponsorTypes sponsorTypeToAdd);
        SponsorTypes UpdateSponsorType(SponsorTypes sponsorTypeToUpdate);
        IEnumerable<SponsorTypes> DeleteSponsorType(SponsorTypes sponsorTypeToDelete);
        bool IsUniqueName(string name);
    }
    public class SponsorTypeService : ISponsorTypeService
    {
        private readonly ISponsorTypeRepository sponsorTypeRepository;
        public SponsorTypeService(ISponsorTypeRepository sponsorTypeRepository)
        {
            this.sponsorTypeRepository = sponsorTypeRepository;
        }
        public IEnumerable<SponsorTypes> GetAllSponsorTypes()
        {
            return sponsorTypeRepository.GetAllSponsorTypes();
        }
        public SponsorTypes GetSponsorTypeById(int id)
        {
            var sponsorTypeAdded = sponsorTypeRepository.GetSponsorTypeById(id);
            return sponsorTypeAdded;
        }

        public SponsorTypes AddSponsorType(SponsorTypes sponsorTypeToAdd)
        {
            if (IsUniqueName(sponsorTypeToAdd.Name))
            {
                return sponsorTypeRepository.AddSponsorType(sponsorTypeToAdd);
            }
            return null;
        }
        public SponsorTypes UpdateSponsorType(SponsorTypes sponsorTypeToUpdate)
        {
            var updateEntity = sponsorTypeRepository.UpdateSponsor(sponsorTypeToUpdate);
            return updateEntity;
        }
        public IEnumerable<SponsorTypes> DeleteSponsorType(SponsorTypes sponsorTypeToDelete)
        {
            sponsorTypeRepository.DeleteSponsorType(sponsorTypeToDelete);
            return sponsorTypeRepository.GetAllSponsorTypes();
        }
        public bool IsUniqueName(string name)
        {
            return sponsorTypeRepository.IsUniqueName(name);
        }

    }
}
