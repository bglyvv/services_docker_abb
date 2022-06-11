using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimestampController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            DateTime now = DateTime.Now;
            int h = now.Hour;
            int m = now.Minute;
            int s = now.Second;
            string timeStamp = (h.ToString()+":"+m.ToString()+":"+s.ToString());

            return timeStamp;
        }
    }
}
