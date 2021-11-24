using System.Collections.Generic;

namespace jlu_api_rest.Database.Models
{
    public class Author
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}