using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace EntityFramework.Models.DTO
{
    public static class DTOExtentions
    {
        public static ProductDTO AsDTO(this Product product) => new ProductDTO(product.Name, product.Description, product.Category, product.Price);
    }

    public record ProductDTO
    (
        [Length(3, 18)] string Name,
        [Length(8, 64)] string Description,
        [Length(8, 32)] string Category,
        decimal Price
    );
}
