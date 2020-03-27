using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyFirstDatabaseCodeFirstMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyFirstDatabaseCodeFirstMVC.Context
{
    public class ProductManagementContext:DbContext
    {
        /*
         * The name of the connection string is passed into the constructor.
         * This name will be used in web.config file
         */
        public ProductManagementContext() : base("ProductManagementContextDB")
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        /*
         * This code will remove the pluralizing convention that is the default behavior
         * for all model builders --> You will then be able to create tables with singular names.
         */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
