//I create a option to enter number of motors carrying packages. It's an int because it's an whole number
Console.Write("How many motors are carrying the packages? ");
int motors = int.Parse(Console.ReadLine());

// Ask to enter the total weight of packages in kg
// Convert the input text into a double so calculations are possible
Console.Write("How many kg of packages? ");
double weight = double.Parse(Console.ReadLine());

// Computes the weight with the motors
double W_calc = weight / motors;

// Checking if the weight is within the motor limits with branching. 
    if (W_calc <= 5.6)
    {
    Console.WriteLine("Yes, the conveyor belt can carry the packages.");
    }
    else
    {
    Console.WriteLine("No,  the conveyor belt cant carry packages.");
    }
 
