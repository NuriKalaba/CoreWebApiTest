using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApiTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApiTest.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase {
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get() {
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id) {
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] TodoItem value) {
			var erden = 0;
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] TodoItem value) {
			var erden = 0;
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id) {
		}
	}
}
