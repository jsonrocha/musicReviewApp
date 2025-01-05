﻿using Microsoft.EntityFrameworkCore;
using MusicReviewApp.Models;
using System.Collections.Generic;

namespace MusicReviewApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }

}
