using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPITest2.Models
{
    public class EntityDbInitializer: DropCreateDatabaseAlways<EntityContext>
    {
        protected override void Seed(EntityContext db)
        {
            db.Entityes.Add(new Entity { EntityName = "randomName", DateTime = DateTime.Today });
            base.Seed(db);
        }
    }    
}