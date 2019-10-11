using Conference.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface IWorkshopRepository
    {
        IEnumerable<Workshops> GetAllWorkshops();
        Workshops GetWorkshopById(int id);
        Workshops AddWorkshop(Workshops workshopToAdd);
        Workshops UpdateWorkshop(Workshops workshopToUpdate);
        IEnumerable<Workshops> DeleteWorkshop(Workshops workshopToDelete);
        bool IsUniqueName(string name);


    }
    public class WorkshopRepository:IWorkshopRepository
    {
        private readonly ConferenceContext conferenceContext;

        public WorkshopRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }


        public IEnumerable<Workshops> GetAllWorkshops()
        {
            //return conferenceContext.Workshops.ToList();
            return conferenceContext.Workshops.Include(x => x.Speaker).ToList();
        }

        public Workshops GetWorkshopById(int id)
        {
            var getWorkshopById= conferenceContext.Workshops.Find(id);
            return getWorkshopById;
        }
        public Workshops AddWorkshop(Workshops workshopToAdd)
        {
            var addedEntity = conferenceContext.Workshops.Add(workshopToAdd);
            conferenceContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Workshops UpdateWorkshop(Workshops workshopToUpdate)
        {
            var updatedEntity = conferenceContext.Workshops.Update(workshopToUpdate);
            conferenceContext.SaveChanges();
            return updatedEntity.Entity;
        }
        public IEnumerable<Workshops> DeleteWorkshop(Workshops workshopToDelete)
        {
            var deletedEntity = conferenceContext.Workshops.Remove(workshopToDelete);
            conferenceContext.SaveChanges();
            return conferenceContext.Workshops.ToList();
        }

        public bool IsUniqueName(string name)
        {
            int number = conferenceContext.Workshops.Count(x => x.Name == name);
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
