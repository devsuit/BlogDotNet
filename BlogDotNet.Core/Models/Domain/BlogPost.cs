namespace BlogDotNet.Core.Models.Domain
{
    public class BlogPost
    {
        internal static object?[]? id;

        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }         
        public string UrlHandle { get; set; }
        public DateTime PablishedDate { get; set; }
        //public DateTime UpdatedAt { get; set; }
        public string Author { get; set; }
        public string Visible { get; set; }
        //public List<Comment> Comments { get; set; }
    }
}
