﻿using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGroopWebApp.Scraper.Data
{
    public class ScraperDBContext : DbContext
    {
        public DbSet<Race> Races { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EI2TOGP\\SQLEXPRESS;Initial Catalog=RunGroops;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
