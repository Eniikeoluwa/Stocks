using myWebApi.Dtos.Comment;
using myWebApi.Models;

namespace  myWebApi.Interfaces
{
      public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
    }
}