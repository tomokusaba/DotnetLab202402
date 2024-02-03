using DotnetLab202402.Server.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotnetLab202402.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class BlogController(Context context) : ControllerBase
{
    private readonly Context _context = context;

    [HttpGet]
    public async Task<IEnumerable<Blog>> Get()
    {
        return await _context.Blogs.AsNoTracking().ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<Blog?> Get(int id)
    {
        return await _context.Blogs.FindAsync(id);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Blog blog)
    {
        _context.Blogs.Add(blog);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = blog.Id }, blog);
    }

    [HttpPut]
    public async Task<IActionResult> Put(Blog blog)
    {
        var update = await Get(blog.Id);
        if (update == null)
        { 
            return NotFound(); 
        }
        update.Title = blog.Title;
        update.Content = blog.Content;
        update.Author = blog.Author;
        update.Updated = DateTime.Now;

        _context.Blogs.Update(update);

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var blog = await _context.Blogs.FindAsync(id);
        if (blog != null)
        {
            _context.Blogs.Remove(blog);
        }
        else
        {
            return NotFound();
        }
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
