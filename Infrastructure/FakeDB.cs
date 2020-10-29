using Core.entity;
using System.Collections.Generic;

namespace Infrastructure
{
    public static class FakeDB
    {
        public static List<Student> teams = new List<Student>();

        public static List<Student> GetTeam()
        {
            return teams;
        }

        public static void UpdateTeam(Team t)
        {
            teams = t.TeamList;
        }
    }
}