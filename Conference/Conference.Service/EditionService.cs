using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Conference.Service
{
    public interface IEditionService
    {
        IEnumerable<Editions> GetAllEditions();
        Editions GetElementById(int id);
        Editions AddEdition(Editions editionToAdd);
        Editions UpdateEdition(Editions editionToUpdate);
        IEnumerable<Editions> DeleteEdition(Editions editionToDelete);
    }
    public class EditionService:IEditionService
    {
        private IEditionRepository editionRepository;

        public EditionService(IEditionRepository editionRepository)
        {
            this.editionRepository = editionRepository;
        }

        public IEnumerable<Editions> GetAllEditions()
        {
            return editionRepository.GetAllEditions();
        }

        public Editions GetElementById(int id)
        {
            var getById=editionRepository.GetElementById(id);
            return getById;
        }
        public Editions AddEdition(Editions editionToAdd)
        {
            if (IsUniqueName(editionToAdd.Name))
            {
                return editionRepository.AddEdition(editionToAdd);
            }
                return null;  
        }

        public Editions UpdateEdition(Editions editionToUpdate)
        {
            var updateEntity= editionRepository.UpdateEdition(editionToUpdate);
            return updateEntity;          
        }

        public IEnumerable<Editions> DeleteEdition(Editions editionToDelete)
        {
            editionRepository.DeleteEdition(editionToDelete);
            return editionRepository.GetAllEditions();
        }
        private bool IsUniqueName(string name)
        {
            return editionRepository.IsUniqueName(name);
        }
    }
}
