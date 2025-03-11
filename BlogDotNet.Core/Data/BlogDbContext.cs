using BlogDotNet.Core.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogDotNet.Core.Data
{
    public class BlogDbContext : DbContext  
    {

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
