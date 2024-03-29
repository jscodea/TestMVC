﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TestMVC.Models;

namespace TestMVC.Data
{
    public class TestMVCContext : IdentityDbContext
    {
        public TestMVCContext (DbContextOptions<TestMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TestMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
