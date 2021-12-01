using RobotLocator.DomainModels;

namespace RobotLocator.Interfaces
{
    public interface IRobotDistanceService
    {
        /// <summary>
        /// Gets the closest robot with the highest battery value within a certain distance of a load. 
        /// </summary>
        /// <param name="load">Passed in load</param>
        /// <param name="robots">List of robots</param>
        /// <param name="distanceThreshold">Distance threshold where the higher battery robot will be selected even if there is a closer robot</param>
        /// <returns></returns>
        RobotDistance GetClosestRobot(Load load, IEnumerable<Robot> robots, int distanceThreshold = 10);
    }
}
