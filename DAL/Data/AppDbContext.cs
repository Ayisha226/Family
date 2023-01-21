using System;
using System.Collections.Generic;
using System.Text;
using DAL.Identity;
using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
      public DbSet<Image> Images { get; set; }
      public  DbSet<Card> Cards{ get; set; }
    }
}
