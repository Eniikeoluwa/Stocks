using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.CodeAnalysis.Options;

namespace myWebApi.Models
{
    [Table("Portfolios")]
    public class Portfolio
    {
        public string AppUserId { get; set; }
        public int StockId { get; set; }
        public AppUser AppUser { get; set; }
        public Stock Stock { get; set; }
    }
}