using BlogDotNet.Core.Models.Domain;

namespace BlogDotNet.Core.Repository
{
    public interface IBlogRepository
    {
        Task<IEnumerable<BlogPost>> GetAllAsync ();
        Task<BlogPost> GetAsync(Guid id, IDataTokensMetadata dataTokensMetadata);
        Task<BlogPost> AddAsync(BlogPost blogPost);
        Task<BlogPost> UpdateAsync(BlogPost blogPost);
        Task<BlogPost> DeleteAsync(Guid id);
    }
}
