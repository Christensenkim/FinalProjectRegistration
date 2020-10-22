using System;
using System.Collections.Generic;
using System.Text;

namespace Core.entity
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string PostalDistrict { get; set; }
        public string Email { get; set; }

        //public Student(int id, string name, string address, int zipCode, string postalDistrict)
        //{
        //    ID = id;
        //    Name = name;
        //    Address = address;
        //    ZipCode = zipCode;
        //    PostalDistrict = postalDistrict;
        //}
        //public Student(int id, string name, string address, int zipCode, string postalDistrict, string email)
        //{
        //    ID = id;
        //    Name = name;
        //    Address = address;
        //    ZipCode = zipCode;
        //    PostalDistrict = postalDistrict;
        //    Email = email;
        //}
    }
}
