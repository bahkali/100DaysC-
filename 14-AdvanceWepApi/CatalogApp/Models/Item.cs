using System;

namespace CatalogApp.Models
{
    public class Item
    {
        public Guid Id { get; init; }

        public string  Name { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreateDate { get; set; }
    }
}