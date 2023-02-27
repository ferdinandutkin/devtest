namespace DeveloperTest.Design;

public abstract class Vehicle
{
    public uint MaxSpeed { get; }
    public uint WheelCount { get; }
    public uint DoorCount { get; }

    public Vehicle(uint maxSpeed, uint wheelCount, uint doorCount)
    {
        MaxSpeed = maxSpeed;
        WheelCount = wheelCount;
        DoorCount = doorCount;
    }
}
