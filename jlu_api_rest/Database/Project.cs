using System.Collections.Generic;

namespace jlu_api_rest.Database.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}