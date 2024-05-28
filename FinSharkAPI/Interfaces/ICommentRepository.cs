using FinSharkAPI.Dtos.Comment;
using FinSharkAPI.Dtos.Stock;
using FinSharkAPI.Models;

namespace FinSharkAPI.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment comment);
        Task<Comment?> UpdateAsync(int id, Comment commentDto);
        Task<Comment?> DeleteAsync(int id);
    }
}
