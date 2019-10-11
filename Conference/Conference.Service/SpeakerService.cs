using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISpeakerService
    {
        IEnumerable<Speakers> GetAllSpeakers();
        Speakers GetSpeakerById(int id);
        Speakers AddSpeaker(Speakers speakerToAdd);
        Speakers UpdateSpeaker(Speakers speakerToUpdate);
        IEnumerable<Speakers> DeleteSpeaker(Speakers speakerToDelete);
        bool IsUniqueName(string name);

    }
    public class SpeakerService:ISpeakerService
    {
        private readonly ISpeakerRepository speakerRepository;
        public SpeakerService(ISpeakerRepository speakerRepository)
        {
            this.speakerRepository = speakerRepository;
        }

        public IEnumerable<Speakers> GetAllSpeakers()
        {
            return speakerRepository.GetAllSpeakers();
        }

        public Speakers GetSpeakerById(int id)
        {
            var getSpeakerById = speakerRepository.GetSpeakerById(id);
            return getSpeakerById;
        }
        public Speakers AddSpeaker(Speakers speakerToAdd)
        {
            if (IsUniqueName(speakerToAdd.CompanyName))
            {
                return speakerRepository.AddSpeaker(speakerToAdd);
            }
            return null;
        }
        public Speakers UpdateSpeaker(Speakers speakerToUpdate)
        {
            var updateEntity = speakerRepository.UpdateSpeaker(speakerToUpdate);
            return updateEntity;
        }

        public bool IsUniqueName(string name)
        {
            return speakerRepository.IsUniqueName(name);
        }

        public IEnumerable<Speakers> DeleteSpeaker(Speakers speakerToDelete)
        {
            speakerRepository.DeleteSpeaker(speakerToDelete);
            return speakerRepository.GetAllSpeakers();
        }
    }
}
