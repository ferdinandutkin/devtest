﻿using DeveloperTest.Design;
using DeveloperTest.Reflection;
using Functionality;
using Functionality.Serialization;
using Functionality.Serialization.Abstractions;

void SerializeVehicles()
{
    InstanceSerializationService<Vehicle>.Serialize(new FileSerializer(new JsonSerializer()), "vehicles.json");
}

SerializeVehicles();

foreach (var subtypeName in  typeof(Vehicle).GetSubtypes()
             .Select(subtype => subtype.Name)
             .OrderBy(@string => @string, StringComparer.OrdinalIgnoreCase))
{
    Console.WriteLine(subtypeName);
}