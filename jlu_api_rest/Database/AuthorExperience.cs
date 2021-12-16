using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jlu_api_rest.Database;

public class AuthorExperience
{
    public int IdAuthor { get; set; }
    public int IdExperience { get; set; }

    [ForeignKey(nameof(IdAuthor))] public Author Author { get; set; }

    [ForeignKey(nameof(IdExperience))] public Experience Experience { get; set; }
}