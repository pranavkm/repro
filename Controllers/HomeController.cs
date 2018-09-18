using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace repro.Controllers
{
    [Route("[action]")]
    public class HomeController : Controller
    {
        public readonly TestModel Model = new TestModel
        {
            SomeText = @"<div class=""some-css""><h1>Hello world</h1></div>"
        };

        public Task<JsonResult> CustomizedSettings()
        {
            var settings = new JsonSerializerSettings
            {
                StringEscapeHandling = StringEscapeHandling.EscapeHtml,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return Task.FromResult(Json(new { success = true, result = Model }, settings));
        }

        public Task<JsonResult> DefaultSettings()
        {
            return Task.FromResult(Json(new { success = true, result = Model }));
        }
    }

    public class TestModel
    {
        public string SomeText { get; set; }
    }
}
