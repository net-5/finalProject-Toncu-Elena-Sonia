using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface IEditionRepository
    {
        IEnumerable<Editions> GetAllEditions();
        Editions GetElementById(int id);
        Editions AddEdition(Editions editionToAdd);
        Editions UpdateEdition(Editions editionToUpdate);
        IEnumerable<Editions> DeleteEdition(Editions editionToDelete);
        bool IsUniqueName(string name);
    }
    public class EditionRepository:IEditionRepository
    {
        private ConferenceContext conferenceContext;

        public EditionRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public IEnumerable<Editions> GetAllEditions()
        {
            return conferenceContext.Editions.ToList();
        }

        public Editions GetElementById(int id)
        {
            var getById=conferenceContext.Editions.Find(id);
            return getById;
        }
        public Editions AddEdition(Editions editionToAdd)
        {
            var addEntity = conferenceContext.Editions.Add(editionToAdd);
            conferenceContext.SaveChanges();
            return addEntity.Entity;
        }
        public Editions UpdateEdition(Editions editionToUpdate)
        {
            var updatedEntity = conferenceContext.Editions.Update(editionToUpdate);
            conferenceContext.SaveChanges();
            return updatedEntity.Entity;
        }
        public IEnumerable<Editions> DeleteEdition(Editions editionToDelete)
        {
            var removeEntity = conferenceContext.Editions.Remove(editionToDelete);
            conferenceContext.SaveChanges();
            return conferenceContext.Editions.ToList();
        }
        public bool IsUniqueName(string name)
        {
            int number = conferenceContext.Editions.Count(x => x.Name == name);
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
