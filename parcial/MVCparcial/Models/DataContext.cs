﻿using System.Data.Entity;

namespace MVCparcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCparcial.Models.Product> Products { get; set; }
    }
}