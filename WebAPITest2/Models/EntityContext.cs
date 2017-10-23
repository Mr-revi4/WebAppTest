using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPITest2.Models
{
    public class EntityContext: DbContext
    {
        public DbSet<Entity> Entityes { get; set; }
    }
}