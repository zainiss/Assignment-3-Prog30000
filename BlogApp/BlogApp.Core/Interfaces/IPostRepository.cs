using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Core.Models;

namespace BlogApp.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllAsync();
        Task<Post?> GetByIdAsync(int id);
        Task<Post> CreateAsync(Post post);
        Task<Post?> UpdateAsync(Post post);
        Task<bool> DeleteAsync(int id);
    }
}