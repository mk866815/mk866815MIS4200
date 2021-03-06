﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mk866815MIS4200.Models; 
using System.Data.Entity;

namespace mk866815MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,mk866815MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    

}