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

        public RobotDistance GetClosestRobot(Load load, IEnumerable<Robot> robots, int distanceThreshold = 10)
        {
            double? shortestDistance = null;
            RobotDistance closestRobotDistance = null;
            foreach (var robot in robots)
            {
                var distance = this._distanceCalculatorService.CalculateDistance(load, robot);
                var robotDistance = new RobotDistance { BatteryLevel = robot.BatteryLevel, DistanceToGoal = distance, RobotId = robot.RobotId };
                var hasHigherBatteryLevel = false;
                if (closestRobotDistance == null) // First robot will always be closest if there's one robot
                {
                    closestRobotDistance = robotDistance;
                    shortestDistance = distance;
                }
                else
                {
                    if (distance <= distanceThreshold && closestRobotDistance.BatteryLevel < robot.BatteryLevel)
                    {
                        hasHigherBatteryLevel = true;
                    }
                    if (shortestDistance > distance || hasHigherBatteryLevel)
                    {
                        shortestDistance = distance;
                        closestRobotDistance = robotDistance;
                    }
                }
            }
            return closestRobotDistance;
        }
    }
}
