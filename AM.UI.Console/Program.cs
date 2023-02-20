// See https://aka.ms/new-console-template for more information
using AM.Core.Domain;

//Console.WriteLine("Hello, World!");
//Question 7
Plane plane= new Plane();   
plane.Capacity= 300;
plane.ManufactureDate = new DateTime(2000, 1, 1);
plane.MyPlaneType = PlaneType.Boeing;
//Question 8
Plane plane1 = new Plane(PlaneType.Airbus,200, new DateTime(2000,1,2));
//Question 9
Plane plane2 = new Plane()
{
    Capacity = 100,
    ManufactureDate = new DateTime(2022,1,3)

};
//Question12/b
Passenger passenger = new Passenger();
Staff   staff= new Staff();
Traveller traveller = new Traveller();
Console.WriteLine(passenger.GetPassengerType());
Console.WriteLine(staff.GetPassengerType());

Console.WriteLine(traveller.GetPassengerType());
//question13
int calculatedAge = 1;
passenger.GetAge(new DateTime(2000, 1, 1), calculatedAge);
Console.WriteLine(calculatedAge);
passenger.BirthDate = new DateTime(2000, 4, 2);
passenger.GetAge(passenger);
Console.WriteLine(passenger.age);

Console.WriteLine(plane);
Console.WriteLine(plane1);
Console.WriteLine(plane2);