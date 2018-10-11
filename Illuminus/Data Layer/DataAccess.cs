using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Illuminus.Data_Layer
{
    public class DataAccess : Controller
    {

        public string RequestDataAccess()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("TodoApp");
            var coll = db.GetCollection<TodoTest>("Todos");

            var id = new ObjectId("5ba637c1c1661c36305f601b");

            return coll.Find(t => t._id == id).ToListAsync().Result[0].text;
        }
    }
    public class TodoTest
    {
        public ObjectId _id { get; set; }
        public string text { get; set; }
        public bool completed { get; set; }
    }

}
