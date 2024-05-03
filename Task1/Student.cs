using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Student
    {
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Speculity { get; set; }
        public sbyte Course { get; set; }
        public string Group {  get; set; }
        public double AverageMark { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
        public WorkPlace WorkPlace { get; set; }
        public Student(string fullName, DateTime birthDay, string speculity, sbyte course, string group, double averageMark, string gender, Address address, WorkPlace workPlace)
        {
            FullName = fullName;
            BirthDay = birthDay;
            Speculity = speculity;
            Course = course;
            Group = group;
            AverageMark = averageMark;
            Gender = gender;
            Address = address;
            WorkPlace = workPlace;
        }
    }
}
