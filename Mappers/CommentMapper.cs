using myWebApi.Dtos.Comment;
using myWebApi.Models;

namespace myWebApi.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreadtedOn = commentModel.CreadtedOn,
                StockId = commentModel.StockId,
            };
        }

         public static CommentDto ToCommentFromCreate(this CreateCommentDto commentDto, int stockId)
        {
            return new CommentDto
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId
            };
        }
    }
}