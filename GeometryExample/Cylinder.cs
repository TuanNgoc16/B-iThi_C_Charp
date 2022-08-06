public class Cylinder
{ 
    static void Main(String[] args)
    {

        double Radius;
        double Height;
        Console.WriteLine("Enter the dimenstion of the cylinder");
        Console.WriteLine("Radius");
        Radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Height");
        Height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n");
        Console.WriteLine("Cylineder Characteristics ");
        Console.WriteLine("Radius: " + Radius +" - " + " Heigth:" + Height);
        /* BaseArea */
        double BaseArea = Radius * Radius * Math.PI;
        Console.WriteLine("Base: " + BaseArea);
        /* LateraArea */
        double LateraArea = 2 * Math.PI * Radius * Height;
        Console.WriteLine("Lateral: " + LateraArea);
        /* TotalArea */
        double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
        Console.WriteLine("Total: " + TotalArea);
        /* Volume */
        double Volume = Math.PI * Radius * Radius * Height;
        Console.WriteLine("Volume: " + Volume);

    }
}