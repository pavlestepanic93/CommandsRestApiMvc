using CommanderNew.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderNew.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }
        public DbSet<Command> Commands { get; set; }
    }
}