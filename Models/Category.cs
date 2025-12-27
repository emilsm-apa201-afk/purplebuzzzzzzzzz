using System.ComponentModel.DataAnnotations;
using purplebuzzzzzzzz.Models.Base;

namespace purplebuzzzzzzzz.Models
{
    public class Category : BaseEntity
    {
        [MaxLength(50, ErrorMessage = "Name 50den cox yazmaq olmaz")]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
