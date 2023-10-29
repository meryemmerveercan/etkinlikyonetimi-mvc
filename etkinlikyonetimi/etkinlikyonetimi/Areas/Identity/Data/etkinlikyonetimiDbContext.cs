﻿using etkinlikyonetimi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace etkinlikyonetimi.Data;

public class etkinlikyonetimiDbContext : IdentityDbContext<IdentityUser>
{
    public etkinlikyonetimiDbContext(DbContextOptions<etkinlikyonetimiDbContext> options)
        : base(options)
    {
    }

	public DbSet<Etkinlik> Etkinlik { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
