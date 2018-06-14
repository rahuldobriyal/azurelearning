using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Mvc;
using AzureLearning.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureLearning.WebAPI.Controllers
{
    [Route("api/testapi")]
    public class TestController : Controller
    {
        private TestData data = null;

        public TestController()
        {
            data = new TestData();
        }
        // GET: api/values
        [HttpGet]
        public TestData Get()
        {
            return data;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public TestData Get(string id)
        {
            if(string.IsNullOrEmpty(id))
            {
                data.Id = id;
            }
            return data;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
