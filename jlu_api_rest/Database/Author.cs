﻿using System.Collections.Generic;

namespace jlu_api_rest.Database
{
    public class Author
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}