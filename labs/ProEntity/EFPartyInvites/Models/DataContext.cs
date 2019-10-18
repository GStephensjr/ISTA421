﻿using Microsoft.EntityFrameworkCore;

namespace EFPartyInvites.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<GuestResponse> Responses { get; set; }
    }
}