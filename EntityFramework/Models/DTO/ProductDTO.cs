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
        string Name,
        string Description,
        string Category,
        decimal Price
    );
}
