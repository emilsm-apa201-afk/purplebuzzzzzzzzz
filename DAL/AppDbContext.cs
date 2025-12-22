using Microsoft.EntityFrameworkCore;
using purplebuzzzzzzzz.Models;

namespace purplebuzzzzzzzz.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slide> Sliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
