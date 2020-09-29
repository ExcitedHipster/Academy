using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1
{
    [AttributeUsage(AttributeTargets.Class)]
    class InfoAttribute : Attribute
    {
        public InfoAttribute(string author, int revision, string description, params string[] reviewers)
        {
            Author = author;
            Revision = revision;
            Description = description;
            Reviewers = reviewers.ToList();
        }
        public string Author { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }
        public List<string>  Reviewers{get;set;}
    }
}
