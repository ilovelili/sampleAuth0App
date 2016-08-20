using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIApplication.Controllers
{
    [Route("api")]
    public class PingController : Controller
    {
        [HttpGet]
        [Route("ping")]
        public string Ping()
        {
            return "Pong";
        }

        [Authorize]
        [HttpGet("claims")]
        public object Claims()
        {
            return User.Claims.Select(c =>
            new
            {
                Type = c.Type,
                Value = c.Value
            });
        }
    }
}
