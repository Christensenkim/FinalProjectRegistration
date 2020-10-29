using System.Collections.Generic;
using Core.entity;

namespace Core.ApplicationService
{
    public interface ITeamService
    {
        void CreateTeam(int id);
        void RemoveTeam(Team t);
        void AddStudentToTeam(Team t, Student s);
        void MoveStudentToNewTeam(Team oldTeam, Team newTeam, Student s);
        void RemoveStudentFromTeam(Team t, Student s);
        IEnumerable<Team> GetAllTeams();
        Team GetTeamById(int id);
        IEnumerable<Student> GetNonAssignedStudents();
    }
}