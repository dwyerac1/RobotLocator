using RobotLocator.DomainModels;

namespace RobotLocator.Interfaces
{
    public interface IRobotDistanceService
    {
        RobotDistance GetClosestRobot(Load load, IEnumerable<Robot> robots, int distanceThreshold = 10);
    }
}
