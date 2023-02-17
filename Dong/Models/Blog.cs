using System.ComponentModel.DataAnnotations;

namespace Dong.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Views { get; set; }
        public string? Contents { get; set; }
        public string? Category { get; set; }
    }
}
