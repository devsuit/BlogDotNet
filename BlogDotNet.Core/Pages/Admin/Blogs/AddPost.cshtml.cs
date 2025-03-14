using BlogDotNet.Core.Data;
using BlogDotNet.Core.Models.Domain;
using BlogDotNet.Core.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogDotNet.Core.Pages.Admin.Blogs
{
    public class AddPostModel : PageModel
    {
        private readonly BlogDbContext blogDbContext;

        [BindProperty]
        public AddBlogPost AddBlogPostRequest { get; set; }
        public AddPostModel(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }
        public void OnGet()
        {
        }
        public void OnPost()
            {
           var blogPost = new BlogPost()
           {
               Heading = AddBlogPostRequest.Heading,
               PageTitle = AddBlogPostRequest.PageTitle,
               Content = AddBlogPostRequest.Content,
               ShortDescription = AddBlogPostRequest.ShortDescription,
               FeaturedImageUrl = AddBlogPostRequest.FeaturedImageUrl,
               UrlHandle = AddBlogPostRequest.UrlHandle,
               PablishedDate = AddBlogPostRequest.PablishedDate,
               Author = AddBlogPostRequest.Author,
               Visible = AddBlogPostRequest.Visible
           };
            blogDbContext.BlogPosts.Add(blogPost);
            blogDbContext.SaveChanges();

        }
        
    }
}
