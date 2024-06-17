
namespace myWebApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreadtedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; }
        //Navigation property
        public  Stock? Stock { get; set; }

        internal static object? ToCommentDto()
        {
            throw new NotImplementedException();
        }
    }
}