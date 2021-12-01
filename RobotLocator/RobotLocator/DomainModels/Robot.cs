using RobotLocator.Interfaces;

namespace RobotLocator.DomainModels
{
    public class Robot : IPoint
    {
        public int RobotId { get; set; }
        public int BatteryLevel { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
