using System;
using System.Collections.Generic;
using System.Linq;
using CatalogApp.Configuration;
using CatalogApp.Models;
using CatalogApp.Models.Dtos;
using CatalogApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {

        private readonly IItemsRepository _repository;
        public ItemsController(IItemsRepository repository)
        {
            _repository = repository;
        }

        // GET /items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = _repository.GetItems().Select( item => item.AsDto());
            return items;
        }

        // GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = _repository.GetItem(id);
            if(item is null) return NotFound();
            return item.AsDto();
        }

        // POST /items
        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItemDto itemDto)
        {
            Item item = new()
            {
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreateDate = DateTimeOffset.UtcNow
            };
            _repository.CreateItem(item);
            return CreatedAtAction("GetItem", new {id = item.Id}, item.AsDto());
        }

        // PUT /items/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id, UpdateItemDto itemDto)
        {
            var existingItem = _repository.GetItem(id);
            if(existingItem is null) return NotFound();
            Item updateItem = new()
            {
                Id = existingItem.Id,
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreateDate = existingItem.CreateDate
            };
            _repository.UpdateItem(updateItem);
            return NoContent();
        }

        // DELETE /items/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(Guid id)
        {
            var existingItem = _repository.GetItem(id);
            if(existingItem is null) return NotFound();
            _repository.DeleteItem(id);
            return NoContent();
        }
    }
}