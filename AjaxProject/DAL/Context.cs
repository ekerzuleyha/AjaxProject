using Microsoft.EntityFrameworkCore;

namespace AjaxProject.DAL
{
    //DbContext den miras aldık
   
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-58O17EO;initial Catalog=AjaxProjectDb;integrated Security=true");
        }

        public DbSet<Product> Products { get; set; }
        //dbsetin türü product alacağı property ismi de products olcak.
    }
}
