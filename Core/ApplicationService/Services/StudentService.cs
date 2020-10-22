using System.Collections.Generic;
using Core.DomainService;
using Core.entity;

namespace Core.ApplicationService.Services
{
    public class StudentService: IStudentService
    {
        private IStudentRepository _studentRepository;

        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public void Add(Student s)
        {
            _studentRepository.Add(s);
        }

        public void Update(Student s)
        {
            _studentRepository.Update(s);
        }

        public void Remove(Student s)
        {
            _studentRepository.Remove(s);
        }
    }
}