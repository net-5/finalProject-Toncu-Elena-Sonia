using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface IWorkshopService
    {
        IEnumerable<Workshops> GetAllWorkshops();
        Workshops GetWorkShopById(int id);
        Workshops AddWorkshop(Workshops workshopToAdd);
        Workshops UpdateWorkshop(Workshops workshoptToUpdate);
        IEnumerable<Workshops> DeleteWorkshop(Workshops workshopToDelete);
    }
    public class WorkshopService:IWorkshopService
    {
        private readonly IWorkshopRepository workshopRepository;

        public WorkshopService(IWorkshopRepository workshopRepository)
        {
            this.workshopRepository = workshopRepository;
        }

        public IEnumerable<Workshops> GetAllWorkshops()
        {
            return workshopRepository.GetAllWorkshops();
        }

        public Workshops GetWorkShopById(int id)
        {
            return workshopRepository.GetWorkshopById(id);
        }
        public Workshops AddWorkshop(Workshops workshopToAdd)
        {
            if (IsUniqueName(workshopToAdd.Name))
            {
                return workshopRepository.AddWorkshop(workshopToAdd);
            }
            return null;
        }


        public Workshops UpdateWorkshop(Workshops workshopToUpdate)
        {
            var updatedEntity = workshopRepository.UpdateWorkshop(workshopToUpdate);
            return updatedEntity;
        }
        public IEnumerable<Workshops> DeleteWorkshop(Workshops workshopToDelete)
        {
            workshopRepository.DeleteWorkshop(workshopToDelete);
            return workshopRepository.GetAllWorkshops();
        }

        private bool IsUniqueName(string name)
        {
            return workshopRepository.IsUniqueName(name);
        }

        
    }
}
