using BlogDotNet.Core.Data;
using BlogDotNet.Core.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogDotNet.Core.Pages.Admin.Blogs
{
    public class EditModel : PageModel
    {
        private readonly BlogDbContext blogDbContext;

        [BindProperty]
        public BlogPost BlogPost { get; set; }
        public EditModel(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }
        public void OnGet(Guid id)
        { var blogPost = blogDbContext.BlogPosts.Find(id);
            //if (blogPost == null)
            //{
            //    RedirectToPage("/Admin/Blogs/List");
            //}
            //BlogPost = blogPost;
        }
    }
}
