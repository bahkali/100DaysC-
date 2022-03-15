using System;

namespace CatalogApp.Models.Dtos
{
    public class ItemDto
    {
        public Guid Id { get; init; }
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreateDate { get; set; }
    }
}