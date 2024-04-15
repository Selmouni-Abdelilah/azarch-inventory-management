using inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace inventory.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options) { }

        public DbSet<Menu> Menus  {get; set;}  
        
    }    
}
    
        