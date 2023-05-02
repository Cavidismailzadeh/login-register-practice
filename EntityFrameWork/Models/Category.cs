using System.ComponentModel.DataAnnotations;

namespace EntityFrameWork.Models
{
    public class Category:BaseEntity
    {
        
        public string Name { get; set; }

        public static implicit operator Category(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
