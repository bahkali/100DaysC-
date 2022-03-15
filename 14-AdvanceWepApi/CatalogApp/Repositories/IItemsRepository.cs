using System;
using System.Collections.Generic;
using CatalogApp.Models;

namespace CatalogApp.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}