using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Illuminus.Data_Layer;
using Microsoft.AspNetCore.Mvc;
using Server_Side_3D.ServerTest;
using UnityEngine;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Illuminus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionManager : Controller
    {
        // GET: /<controller>/

        [HttpGet("{LocalIP}")]
        public ActionResult<string> RequestSession(string IPAddress)
        {
            return new DataAccess().RequestDataAccess() + " " + new CrossProjectTest().test();
        }

    }
}
