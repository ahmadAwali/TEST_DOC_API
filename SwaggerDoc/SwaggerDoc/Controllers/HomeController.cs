using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace SwaggerDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// Retrieves test data.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Home/Test1
        ///
        /// Sample response:
        ///
        ///     "Test1"
        ///
        /// </remarks>
        [HttpGet(Name = "Test1")]
        public string Test1()
        {
            return "Test1";
        }

        /// <summary>
        /// Creates test data.
        /// </summary>
        /// <param name="Model">The test model.</param>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/Home/Test2
        ///     {
        ///         "Id": 1,
        ///         "Name": "TestName",
        ///         "Description": "TestDescription"
        ///     }
        ///
        /// Sample response:
        ///
        ///     "1 TestName TestDescription"
        ///
        /// </remarks>
        [HttpPost(Name = "Test2")]
        public string Test2(TestModel Model)
        {
            return $"{Model.Id} {Model.Name} {Model.Description}";
        }

    }
}
