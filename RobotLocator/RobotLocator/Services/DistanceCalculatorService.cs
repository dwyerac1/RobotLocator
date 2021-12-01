using RobotLocator.Interfaces;

namespace RobotLocator.Services
{
    public class DistanceCalculatorService : IDistanceCalculatorService
    {
        public double CalculateDistance(IPoint point1, IPoint point2)
        {
            var distance = Math.Sqrt((Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2)));
            return distance;
        }
    }
}
