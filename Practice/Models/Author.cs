using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
  public class Author
  {
    public int AuthorId { get; set; }
    [Required(ErrorMessage = "Author must have name: please add a name.")]
    public string Name { get; set; }
    public List<AuthorBook> JoinEntities { get; set; }
 
  }
}