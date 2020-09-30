using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyTask
{
    public class handlerModel : PageModel
    {
        List<String> employee_name = new List<String>();
        
        public ActionResult OnGet()
        {
            employee_name.Add("Anil");
            employee_name.Add("Sunil");
            employee_name.Add("Jayesh");
            employee_name.Add("Manan");
            return Content(JsonSerializer.Serialize(employee_name));


        }

     
        public void onPost()
        {

        }
    }
}