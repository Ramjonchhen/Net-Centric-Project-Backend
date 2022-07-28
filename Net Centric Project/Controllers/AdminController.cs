using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Net_Centric_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly FutsalManagementDBContext dataContext;

        public AdminController(FutsalManagementDBContext dataContext )
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Users>>> Index()
        {
            return Ok(await dataContext.Users.ToListAsync());
        }
    }
}
