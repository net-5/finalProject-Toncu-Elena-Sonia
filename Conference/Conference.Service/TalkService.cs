using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ITalkService
    {
        IEnumerable<Talks> GetAllTalks();
        Talks GetTalkById(int id);
        Talks AddTalk(Talks talkToAdded);
        Talks UpdateTalk(Talks talkToUpdate);
        IEnumerable<Talks> DeleteTalk(Talks talkToDelete);

    }
    public class TalkService : ITalkService
    {
        private readonly ITalkRepository talkRepository;

        public TalkService(ITalkRepository talkRepository)
        {
            this.talkRepository = talkRepository;
        }

        public IEnumerable<Talks> GetAllTalks()
        {
            return talkRepository.GetAllTalks();
        }

        public Talks GetTalkById(int id)
        {
            var talkById = talkRepository.GetTalkById(id);
            return talkById;
        }

        public Talks AddTalk(Talks talkToAdded)
        {
            if (IsUniqueName(talkToAdded.Name))
            {
                return talkRepository.AddTalk(talkToAdded);
            }

            return null;
        }
        private bool IsUniqueName(string name)
        {
            if (talkRepository.IsUniqueName(name) == true)
            {
                return true;
            }
            return false;
        }

        public Talks UpdateTalk(Talks talkToUpdate)
        {
            var updatedEntity = talkRepository.UpdateTalk(talkToUpdate);
            return updatedEntity;
        }

        public IEnumerable<Talks> DeleteTalk(Talks talkToDelete)
        {
            talkRepository.DeleteTalk(talkToDelete);
            return talkRepository.GetAllTalks();
        }
    }
}
