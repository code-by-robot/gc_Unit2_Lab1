// Room Calculator
Console.WriteLine("Welcome to the Room Information Calculator!");

// Get Dimensions
Console.WriteLine("Please enter the length of the room in feet.");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the width of the room in feet.");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the height of the room in feet.");
double height = double.Parse(Console.ReadLine());

//Do math on provided values
double area = length * width;
double perimeter = 2 * length + 2 * width;
double volume = length * width * height;
double surface_area = 2 * (width * length + height * length + height * width);

//Classify Room Size
int small = 250;
int large = 650;
string classification;
if(area <= small)
{
    classification = "small";  
}
else if(area >= large)
{
    classification = "large";
}
else
{
    classification = "medium";
}

//Output to Console
Console.WriteLine("Here are your room stats:");
Console.WriteLine("Area = "+area+" square feet.");
Console.WriteLine("Perimeter = "+perimeter+" feet.");
Console.WriteLine("Volume = "+volume+" cubic feet.");
Console.WriteLine("Surface area = "+surface_area+" square feet.");
Console.WriteLine("This is a "+classification+"-sized room.");

