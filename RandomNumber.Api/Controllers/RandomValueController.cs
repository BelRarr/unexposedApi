using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RandomNumber.Api.Controllers
{
    public class RandomValueController : ApiController
    {
        // GET api/randomvalue
        [Route("api/randomvalue")]
        public int Get()
        {
            return new Random().Next();
        }
    }
}
