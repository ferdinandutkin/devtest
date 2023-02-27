namespace DRPS.Design;

public class Car : Vehicle
{
    public TransmissionType TransmissionType { get; } //lets assume only car has such property
    
    public Car() : base(maxSpeed: 150, wheelCount: 4, doorCount: 4)
    {
        TransmissionType = TransmissionType.Automatic;
    }
}
