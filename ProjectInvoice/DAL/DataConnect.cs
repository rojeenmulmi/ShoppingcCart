using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectInvoice.Models;


namespace ProjectInvoice.DAL
{
    public class DataConnect : DbContext
    {
        public DataConnect(DbContextOptions<DataConnect>options) : base(options) { }
        public DbSet<CustomerDetails> CustomerDetailss { get; set; }
    }
}
