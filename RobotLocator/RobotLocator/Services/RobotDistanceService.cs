using RobotLocator.DomainModels;
using RobotLocator.Interfaces;

namespace RobotLocator.Services
{
    public class RobotDistanceService : IRobotDistanceService
    {

        private readonly IDistanceCalculatorService _distanceCalculatorService;

        public RobotDistanceService(IDistanceCalculatorService distanceCalculatorService)
        {
            _distanceCalculatorService = distanceCalculatorService;
        }

        public RobotDistance GetClosestRobot(Load load, IEnumerable<Robot> robots, int distanceThreshold)
        {
            double? shortestDistance = null;
            RobotDistance closestRobotDistance = null;
            List<RobotDistance> closestDistanceRobots = new List<RobotDistance>();
            var batteryLevelSortedRobots = robots.OrderByDescending(x => x.BatteryLevel); //First sort by battery level
            foreach (var robot in batteryLevelSortedRobots)
            {
                var distance = this._distanceCalculatorService.CalculateDistance(load, robot);
                var robotDistance = new RobotDistance { BatteryLevel = robot.BatteryLevel, DistanceToGoal = distance, RobotId = robot.RobotId };
                if (closestRobotDistance == null) // First robot will always be closest if there's one robot
                {
                    closestRobotDistance = robotDistance;
                    shortestDistance = distance;
                }
                else
                {
                    if (distance < shortestDistance)
                    {
                        closestRobotDistance = robotDistance;
                        shortestDistance = distance;
                        if (distance <= distanceThreshold) break; // Robots were sorted by battery first, break out of the loop
                    }
                }
            }
            return closestRobotDistance;
        }
    }
}
