using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;


namespace DialogFlowAPI.Controllers
{
    public class ApiController : Controller
    {
            [HttpGet]
            public JsonResult Messages()
            {
                var a = new Dictionary<string, int> {{"Alex", 1}, {"Max", 2}, {"Andy", 3}};
                return Json(a);
            }
            
            [HttpPost]
            public JsonResult Messages(Dictionary<string, string> data)
            {
                using (var reader = new StreamReader(Request.Body))
                {
                    var body = reader.ReadToEnd();

                    Debug.Assert(data != null);
                    Console.WriteLine(body);
                    return Json(body);
                }
            }

        }
}