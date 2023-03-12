using Microsoft.EntityFrameworkCore;

namespace STAPP.Infrastructure.Context;

public class MySQLContext : DbContext
{
    public MySQLContext (){}
    public MySQLContext (DbContextOptions<MySQLContext> options) : base(options){}
}