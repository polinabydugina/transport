using System;
using System.Collections;
using System.Collections.Generic;

class Transport
{
    public string Type { get; set; }
    public string Speed { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public string Category { get; set; }
    public string IsRented { get; set; }
    public int Numberofwheels { get; set; }
    public string Motor { get; set; }

    public Transport(string type, string speed, string color, string model, string category, int numberofwheels, string motor, string isRented )
    {
        Type = type;
        Speed = speed;
        Color = color;
        Model = model;
        Category = category;
        IsRented = isRented;
        Numberofwheels = numberofwheels;
        Motor= motor;
    }

    public override string ToString()
    {
        return $"Type: {Type}, Speed: {Speed}, Color: {Color}, Model: {Model}, Category: {Category}, Numberofwheels: {Numberofwheels}, Motor: {Motor}, IsRented: {IsRented} ";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Transport> transportList = new List<Transport>();
        transportList.Add(new Transport("Boat", "30 km/h", "Blue", "Boat Model 1", "Boat Category 1", 0, "ASD", "Да"));
        transportList.Add(new Transport("Motorcycle", "220 km/h", "White", "Motorcycle Model 6", "Motorcycle Category 1", 2, "BSDH", "Да"));
        transportList.Add(new Transport("Boat", "50 km/h", "Red", "Boat Model 4", "Boat Category 1", 0, "RYUYI", "Нет"));
        transportList.Add(new Transport("Car", "100 km/h", "Red", "Car Model 1", "Car Category 1", 4, "nhg", "Да"));
        transportList.Add(new Transport("Car", "150 km/h", "yellow", "Car Model 5", "Car Category 1", 4, "GYDFV", "Нет"));
        transportList.Add(new Transport("Bicycle", "-", "Green", "Bicycle Model 1", "Bicycle Category 1", 2, "-", "Нет"));
        transportList.Add(new Transport("Bicycle", "-", "Black", "Bicycle Model 2", "Bicycle Category 1", 2, "-", "Да"));
        transportList.Add(new Transport("Motorcycle", "150 km/h", "Black", "Motorcycle Model 1", "Motorcycle Category 1", 2, "NHY", "Да"));
        transportList.Add(new Transport("Motorcycle", "170 km/h", "Green", "Motorcycle Model 14", "Motorcycle Category 1", 2, "FHN", "Нет"));
        transportList.Add(new Transport("Scooter", "20 km/h", "Yellow", "Scooter Model 1", "Scooter Category 1", 2, "KTU", "Нет"));
        transportList.Add(new Transport("Scooter", "40 km/h", "Pink", "Scooter Model 51", "Scooter Category 1", 2, "BS VB", "Да"));

        var groupedTransports = transportList.GroupBy(t => t.Type);

        foreach (var group in groupedTransports)
        {
            Console.WriteLine("Transport type: " + group.Key);
            foreach (var transport in group)
            {
                Console.WriteLine(transport);
            }
            Console.WriteLine();
        }


    Console.WriteLine("Choose a type of transport:");

        Console.WriteLine("1. Boat");
        Console.WriteLine("2. Car");
        Console.WriteLine("3. Bicycle");
        Console.WriteLine("4. Motorcycle");
        Console.WriteLine("5. Scooter");

        int choice = int.Parse(Console.ReadLine());

        string chosenType = "";
        switch (choice)
        {
            case 1:
                chosenType = "Boat";
                break;
            case 2:
                chosenType = "Car";
                break;
            case 3:
                chosenType = "Bicycle";
                break;
            case 4:
                chosenType = "Motorcycle";
                break;
            case 5:
                chosenType = "Scooter";
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        bool foundTransport = false;
        foreach (Transport transport in transportList)
        {
            if (transport.Type == chosenType)
            {
                Console.WriteLine(transport);
                foundTransport = true;
            }
        }

        if (!foundTransport)
        {
            Console.WriteLine("No transports of chosen type found.");
        }
    }
}
abstract class Motortransport
{
    public void Move()
    {
        Console.WriteLine("Транспортное средство движется");
    }
}
    class boat : Motortransport { }
    class Motorcycle : Motortransport { }
    class Car : Motortransport { }
    class Bicycle : Motortransport { }
    class Scooter : Motortransport { }


