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

        public async Task<IActionResult> OnGet(Guid id)
        {
            BlogPost = await blogDbContext.BlogPosts.FindAsync(id);

            if (BlogPost == null)
            {
                return RedirectToPage("/Admin/Blogs/List"); // Redirect if blog post not found
            }

            return Page(); // Return the page with BlogPost data
        }

        public async Task<IActionResult>  OnPostEdit()
        {
            var existingBlogPost = await blogDbContext.BlogPosts.FindAsync(BlogPost.Id);

            if (existingBlogPost != null)
            {
                existingBlogPost.Heading = BlogPost.Heading;
                existingBlogPost.PageTitle = BlogPost.PageTitle;
                existingBlogPost.Content = BlogPost.Content;
                existingBlogPost.ShortDescription = BlogPost.ShortDescription;
                existingBlogPost.FeaturedImageUrl = BlogPost.FeaturedImageUrl;
                existingBlogPost.UrlHandle = BlogPost.UrlHandle;
                existingBlogPost.PablishedDate = BlogPost.PablishedDate; // Fixed Typo
                existingBlogPost.Author = BlogPost.Author;
                existingBlogPost.Visible = BlogPost.Visible;

                await blogDbContext.SaveChangesAsync();
            }

            return RedirectToPage("/Admin/Blogs/List");
        }
        public async Task<IActionResult> OnPostDelete()
        { var existingBlog = await blogDbContext.BlogPosts.FindAsync(BlogPost.Id);
            if (existingBlog != null) {
                blogDbContext.BlogPosts.Remove(existingBlog);
                await blogDbContext.SaveChangesAsync();
                return RedirectToPage("/Admin/Blogs/List");
            }
            return Page();
                }
    }
}
