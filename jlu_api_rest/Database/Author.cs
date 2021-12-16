using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace jlu_api_rest.Database;

public class Author
{
    [Key]
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public ICollection<Project> Projects { get; set; }
}