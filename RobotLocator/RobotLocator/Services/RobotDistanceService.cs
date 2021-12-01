using RobotLocator.DomainModels;
using RobotLocator.Interfaces;

namespace RobotLocator.Services
{
    public class RobotDistanceService : IRobotDistanceService
    {
        public RobotDistance GetClosestRobot(Load load, IEnumerable<Robot> robots, int distanceThreshold = 10)
        {
            throw new NotImplementedException();
        }
    }
}
