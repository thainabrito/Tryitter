using Microsoft.AspNetCore.Mvc;
using Tryitter.Models;

namespace Tryitter.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        List<Login> Logins = new List<Login>();
        [HttpGet(Name = "Login")]
        public IEnumerable<Login> Get()
        {
            Logins.Add(new Login { Email = "email1", Password = "pass1" });
            Logins.Add(new Login { Email = "email2", Password = "pass1" });
            Logins.Add(new Login { Email = "email3", Password = "pass1" });
            
            return Logins;
        }

        [HttpPost(Name = "Login")]
        public void Post()
        {
        }


    }
}
