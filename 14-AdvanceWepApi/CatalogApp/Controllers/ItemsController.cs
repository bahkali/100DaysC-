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

    }
}