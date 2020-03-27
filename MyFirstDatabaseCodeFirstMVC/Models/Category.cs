using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstDatabaseCodeFirstMVC.Models
{
    public class Category
    {
        /*
         * The ID property will become the primary key column of the database table.
         * By default, the EF interprets a property named ID or 'classname' ID as the primary key.
         * Eg: Create primary key: Id or CategoryId
         */
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}