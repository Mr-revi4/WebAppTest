using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPITest2.Models;

namespace WebAPITest2.Controllers
{    
    public class EntityController : ApiController
    {
        EntityContext db;
        public IEnumerable<Entity> Get()
        {
            db = new EntityContext();
            return db.Entityes;
        }
    }
}
