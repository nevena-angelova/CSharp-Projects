using System;
using System.Collections.Generic;
using System.Text;
using FCMD.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FCMD.Data
{
    public class FcmdDbContext : IdentityDbContext<FcmdUser>
    {
        public DbSet<Cat> Cats { get; set; }

        public FcmdDbContext(DbContextOptions<FcmdDbContext> options)
            : base(options)
        {
        }
    }
}
