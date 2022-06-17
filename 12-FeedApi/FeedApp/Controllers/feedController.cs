using System;
using System.Threading.Tasks;
using FeedApp.data;
using FeedApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FeedApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class feedController : ControllerBase
    {
        public readonly feedDbContext _context;

        public feedController(feedDbContext context)
        {
            _context = context;

        }

        [HttpGet("/feed/post")]
        public async Task<IActionResult> GetPost()
        {
            var posts = await _context.Posts.ToListAsync();
            return Ok(posts);
        }

        [HttpGet("/feed/post/{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);
            if(post == null) return NotFound();
            return Ok(post);
        }

        [HttpPost("/feed/post")]
        public async Task<IActionResult> CreatePost(PostModel data)
        {
            if(ModelState.IsValid){
                await _context.Posts.AddAsync(data);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetPost", new {data.Id}, data);
            }
            return new JsonResult("Something went wrong") { StatusCode = 500};
        }

        [HttpPut("/feed/post/{id}")]
        public async Task<IActionResult> UpdatePost(int id, PostModel data)
        {
            var existingPost = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);
            if(existingPost == null) return NotFound();
                
            existingPost.Title = data.Title;
            existingPost.Content = data.Content;
            existingPost.ImageUrl = data.ImageUrl;
            
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetPost", new {data.Id}, data);
            
        }

        [HttpDelete("/feed/post/{id}")]
        public IActionResult DeletePost(int id)
        {
            return Ok("Post Deleted");
        }
    }
}