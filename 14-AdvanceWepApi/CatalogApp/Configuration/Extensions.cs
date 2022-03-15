using CatalogApp.Models;
using CatalogApp.Models.Dtos;

namespace CatalogApp.Configuration
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto{
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreateDate = item.CreateDate
            };
        }
    }
}