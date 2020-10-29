using Core.DomainService;
using Core.entity;
using System.Collections.Generic;
using System.IO.Compression;

namespace Core.ApplicationService.Services
{
    public class TeamService : ITeamService
    {
        private ITeamRepository _TeamRepository;

        public TeamService(ITeamRepository repo)
        {
            _TeamRepository = repo;
        }

        public void AddStudentToTeam(Team t, Student s)
        {
            throw new System.NotImplementedException();
        }

        public void CreateTeam(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Team> GetAllTeams()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Student> GetNonAssignedStudents()
        {
            throw new System.NotImplementedException();
        }

        public Team GetTeamById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void MoveStudentToNewTeam(Team oldTeam, Team newTeam, Student s)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveStudentFromTeam(Team t, Student s)
        {
            t.TeamList.Remove(s);

            _TeamRepository.Update(t);
        }

        public void RemoveTeam(Team t)
        {
            throw new System.NotImplementedException();
        }
    }
}