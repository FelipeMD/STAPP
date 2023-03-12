using Microsoft.EntityFrameworkCore;
using STAPP.Domain.Produtos;

namespace STAPP.Infrastructure.Migrations.Context;

public class MySQLContext : DbContext
{
    public MySQLContext (){}
    public MySQLContext (DbContextOptions<MySQLContext> options) : base(options){}
    
    public DbSet<Produto> Produtos { get; set; }
}