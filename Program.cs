
while (true)
{
    Console.WriteLine("Enter color code(1-4)");
    byte color = Convert.ToByte(Console.ReadLine());
    if (color <= 4 && color>0)
    {
        var color1 = (ColorType)color;
        Console.WriteLine(color1);
        break;
    }
    Console.WriteLine("Invalid color code");

}


while (true)
{
    Console.WriteLine("Enter color code(1-4)");
    string color = Console.ReadLine();
    if (int.TryParse(color, out int num))
    {
        
        Console.WriteLine(color);
        break;
    }
    else
    {
        Console.WriteLine("Invalid color code");

    }

}
enum ColorType { 
    Red = 1,
    Green, 
    Blue, 
    Yellow
}