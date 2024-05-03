using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class WorkPlace
    {
        public string Company { get; set; }
        public string Post {  get; set; }
        public sbyte RequiredExperience { get; set; }
        public WorkPlace(string company, string post, sbyte requiredExperience)
        {
            Company = company;
            Post = post;
            RequiredExperience = requiredExperience;
        }
        public override string ToString()
        {
            return $"Company: {Company}; Post: {Post}; RequiredExperience: {RequiredExperience}";
        }
    }
}
