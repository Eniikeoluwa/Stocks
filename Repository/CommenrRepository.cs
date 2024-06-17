using Microsoft.EntityFrameworkCore;
using myWebApi.Data;
using myWebApi.Dtos.Comment;
using myWebApi.Interfaces;
using myWebApi.Models;

namespace myWebApi.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;
        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Comment> CreateAsync(Comment commentModel)
        {
            await _context.Comments.AddAsync(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        async Task<Comment?> ICommentRepository.GetByIdAsync(int id)
        {
            return await _context.Comments.FindAsync();
        }
    }
}