using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace jlu_api_rest.Database;

public class Project
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Author Author { get; set; }
    public ICollection<Tag> Tags { get; set; }
}