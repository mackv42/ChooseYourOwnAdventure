using System;
using System.Collections.Generic;
using System.Text;
using ChooseYourOwnAdventure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChooseYourOwnAdventure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Option> Options { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
