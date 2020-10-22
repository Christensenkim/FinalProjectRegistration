using System;
using System.Collections.Generic;
using Core.DomainService;
using Core.entity;

namespace Core.ApplicationService.Services
{
    public class StudentService: IStudentService
    {
        private IStudentRepository _studentRepository;

        public StudentService(IStudentRepository repo)
        {
            _studentRepository = repo;
        }

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
            if (s.Name is null || s.Address is null || s.PostalDistrict is null)
            {
                throw new InvalidOperationException();
            }
            if (s.ID > 0 && s.Name.Length > 1 && s.Address.Length > 1 && s.ZipCode > 0 && s.PostalDistrict.Length > 1)
            {
                _studentRepository.Add(s);
            }
            else
            {
                throw new InvalidOperationException();
            }

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