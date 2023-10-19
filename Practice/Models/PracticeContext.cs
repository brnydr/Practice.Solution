using Microsoft.EntityFrameworkCore;

namespace Practice.Models
{
  public class PracticeContext: DbContext
  {
    public DbSet<Author> Authors {get; set;}
    public DbSet<Book> Books { get; set; }
    public DbSet<AuthorBook> AuthorBooks { get; set; }
    public PracticeContext(DbContextOptions options) : base(options) {}
  }
}