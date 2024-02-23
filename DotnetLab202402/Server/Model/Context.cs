using DotnetLab202402.Shared;
using Microsoft.EntityFrameworkCore;

namespace DotnetLab202402.Server.Model;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Books> Books { get; set; }
}
