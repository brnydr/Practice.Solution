using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
  public class Author
  {
    public int AuthorId { get; set; }
    [Required]
    public string Name { get; set; }
    public List<AuthorBook> JoinEntities { get; set; }
 
  }
}