using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dong.Models
{
    public class BlogCategoryModel
    {
        public List<Blog>? Blogs { get; set; }
        public SelectList? Category { get; set; }
        public string? BlogCategory { get; set; }
        public string? SearchString { get; set; }
    }

}
