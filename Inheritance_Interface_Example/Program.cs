using BetterVersion;
/*
    * Inheritabce is not code-sharing
    * Is - a relationship : DON'T STRETCH THIS RELATIONSHIP
    * Need to share common logic : Sharing just properties or methıd signatures is not enough
    * Inheritance can put you in a corner : Do not strecth is - a relationship so much. Be careful
    * You need to ask the question : What is the point => there should be a value that inheritance puts on the table 
 */

/*
    * In original version we have a base class : RentalVehicle 
    * It has two methods : StartEngine and StopEngine
    * RentalCar, RentalTruck and RentalBoat inherits the base RentalVehicle class
    * Three child classes may override the methods of base class because they all have an engine.
    * ***** The problem occured when we add RentalSailBoat class which doesn't have an engine.
    * At this point using inheritance is not so valid or logical. We are now also breaking Liskov Subs. Principle
    * The solution is to use interfaces after this part. Look at the better version file in this project for the solution
 */  

BetterVersionProgram.Run();

Console.ReadKey();