using System.ComponentModel.DataAnnotations;

namespace jlu_api_rest.Domain.Dto
{
    public class PostAuthorDto
    {
        [Required]
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
