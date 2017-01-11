using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Corecsharp2.Models
{
    public class CCDbContext : DbContext
    {



        public DbSet<Contact> Contacts { get; set; }
    }
}