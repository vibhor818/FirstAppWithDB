using FirstAppWithDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWithDB.Context
{
    public class VBContext:DbContext
    {
        string _conSt;
        public VBContext(string conStr)
        {
            this._conSt = conStr;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this._conSt);
           // optionsBuilder.UseSqlite("Data Source=vblitedb.db");
        }
        //fluent api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Blog>()
            //      .ToTable("Blogs");

            //modelBuilder.HasDefaultSchema("vb");
        }
       // public DbSet<Emp> Emp { get; set; }
        public DbSet<Blog>  Blogs { get; set; }
    }
}
