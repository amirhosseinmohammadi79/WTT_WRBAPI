using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WttCore.Models;

namespace WttCore.Controllers
{
    public class UserControler : Controller
    {
     

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
          
            return Ok();
            
        }
    }
}
