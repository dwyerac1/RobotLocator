using Microsoft.AspNetCore.Mvc;
using RobotLocator.DomainModels;

namespace RobotLocator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RobotDistanceController : ControllerBase
    {
        // POST: api/RobotDistance
        [HttpPost]
        public RobotDistance CalculateRobotDistance(Load load)
        {
            return null;
        }
    }
}