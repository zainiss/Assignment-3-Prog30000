using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Core.Models;

namespace BlogApp.Core.Interfaces
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<IEnumerable<Comment>> GetByPostIdAsync(int postId);
        Task<Comment> CreateAsync(Comment comment);
        Task<Comment?> UpdateAsync(Comment comment);
        Task<bool> DeleteAsync(int id);
    }
}