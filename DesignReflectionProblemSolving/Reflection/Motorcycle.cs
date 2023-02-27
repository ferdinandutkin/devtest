using DRPS.Design;

namespace DRPS.Reflection;

internal class Motorcycle : Vehicle
{
    public Motorcycle() : base(maxSpeed: 200, wheelCount: 2, doorCount: 0)
    {
    }
}