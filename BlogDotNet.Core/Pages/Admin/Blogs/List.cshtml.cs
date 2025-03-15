using BlogDotNet.Core.Data;
using BlogDotNet.Core.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace BlogDotNet.Core.Pages.Admin.Blogs
{
    public class ListModel : PageModel
    {
        private readonly BlogDbContext blogDbContext;

        public List <BlogPost> BlogPosts { get; set; }
        public ListModel(BlogDbContext  blogDbContext)
        {
                this.blogDbContext = blogDbContext;
        }
        public void OnGet()
        {
          BlogPosts =  blogDbContext.BlogPosts.ToList();
        }
    }
}
