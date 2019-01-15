using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LuckySpin
{
    public class SpinnerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            Lucky7 lucky7 = new Lucky7();
            return new ContentResult { Content = lucky7.Output(id), ContentType ="text/html" };
            //return lucky7.Output(id);
        }
    }
}
