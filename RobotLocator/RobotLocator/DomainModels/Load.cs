using RobotLocator.Interfaces;

namespace RobotLocator.DomainModels
{
    public class Load : IPoint
    {
        public int LoadId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
