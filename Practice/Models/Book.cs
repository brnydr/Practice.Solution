using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
  public class Book
  {
    
    public int BookId { get; set; }

    [Required]
    public string Title { get; set; }

    public List<AuthorBook> JoinEntities { get; set; }
 
  }
}