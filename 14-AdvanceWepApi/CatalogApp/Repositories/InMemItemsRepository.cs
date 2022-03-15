using System;
using System.Collections.Generic;
using System.Linq;
using CatalogApp.Models;

namespace CatalogApp.Repositories
{
    

    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreateDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreateDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 18, CreateDate = DateTimeOffset.UtcNow }
        };

        // Get items
        public IEnumerable<Item> GetItems()
        {
            return items;
        }
        // Get one item
        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item i)
        {
            // Find the item
            //var existingItem = items.Where(item => item.Id == i.Id).SingleOrDefault();
            var index = items.FindIndex(existingItem => existingItem.Id == i.Id);
            items[index] = i;
        }

        public void DeleteItem(Guid id)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == id);
            items.RemoveAt(index);
        }
    }
}