using APICatalogo.Domain;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;

public class ApiCatalogoContext(DbContextOptions<ApiCatalogoContext> options) : DbContext(options)
{
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
}