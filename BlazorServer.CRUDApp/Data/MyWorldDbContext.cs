using Microsoft.EntityFrameworkCore;
using BlazorServer.CRUDApp.Entities;

namespace BlazorServer.CRUDApp.Data
{
    public class MyWorldDbContext : DbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
        {

        }
        public DbSet<Gadget> Gadgets { get; set; }
    }
}