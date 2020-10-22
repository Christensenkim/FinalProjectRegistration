using System.Collections.Generic;
using Core.entity;

namespace Core.DomainService
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        void Add(Student s);
        void Update(Student s);
        void Remove(Student s);
    }
}