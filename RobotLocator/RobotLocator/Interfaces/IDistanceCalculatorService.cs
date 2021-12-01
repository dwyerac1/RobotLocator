namespace RobotLocator.Interfaces
{
    public interface IDistanceCalculatorService
    {
        double CalculateDistance(IPoint point1, IPoint point2);
    }
}
