using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1.Models;
using System.Data.Entity;

namespace Project_1.DAL
{
    public class ISFAQContext : DbContext
    {
        public ISFAQContext()
            : base("ISFAQContext")
        {

        }

        public DbSet<Customer_Instruments> Customers_Instrument { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Instruments> Instrument { get; set; }
    }
}