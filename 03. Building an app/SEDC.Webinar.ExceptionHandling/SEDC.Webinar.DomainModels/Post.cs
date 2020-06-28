using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Webinar.DomainModels
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatedBy { get; set; }

        public Post(int id, string title, string content, string createdBy)
        {
            Id = id;
            Title = title;
            Content = content;
            CreatedBy = createdBy;
        }
    }
}
