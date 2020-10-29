using Core.entity;
using System.Collections.Generic;

namespace Core.DomainService
{
    public interface ITeamRepository
    {
        void Add(Team t);
        void Update(Team t);
        void Remove(Team t);
        IEnumerable<Team> GetAll();
        Team GetById(int id);

    }
}