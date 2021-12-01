using Microsoft.AspNetCore.Mvc;
using RobotLocator.DomainModels;
using RobotLocator.Interfaces;
using System.Net;

namespace RobotLocator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RobotDistanceController : ControllerBase
    {
        private readonly IRobotDistanceService _robotDistanceService;
        // Should these be configuration values?
        private readonly string _externalUrl = "https://60c8ed887dafc90017ffbd56.mockapi.io/robots";
        private readonly string _altExternalUrl = "https://svtrobotics.free.beeceptor.com/robots";
        public RobotDistanceController(IRobotDistanceService robotDistanceService)
        {
            _robotDistanceService = robotDistanceService;
        }
        // POST: api/RobotDistance
        [HttpPost]
        public RobotDistance CalculateRobotDistance(Load load)
        {
            var robots = GetRobotExternalData(_externalUrl, _altExternalUrl);
            var robotDistance = this._robotDistanceService.GetClosestRobot(load, robots);
            return robotDistance;
        }
        //TODO: See about using http client instead, but don't have time
        private static IEnumerable<Robot> GetRobotExternalData(string mainUrl, string altUrl)
        {
            // Call the external website and populate the robot list
            return new List<Robot>();

        }
    }
}