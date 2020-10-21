using System;

namespace pen_class_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test - default constructor
            Pen defaultPen = new Pen();
            Console.WriteLine($"Default pen: {defaultPen.Brand}, {defaultPen.Colour}, {defaultPen.MaxInk} mL, {defaultPen.InkLevel} mL, {defaultPen.HasLid}");


            // Test - greedy constructor
            Pen greedyPen = new Pen( "Sharpie", "red", 100, 53, false );
            Console.WriteLine($"Greedy pen: {greedyPen.Brand}, {greedyPen.Colour}, {greedyPen.MaxInk} mL, {greedyPen.InkLevel} mL, {greedyPen.HasLid}");

            // Test - Write() method without params
            defaultPen.Write();
            greedyPen.Write();

            // Test - Write() method with params
            defaultPen.Write(12);
            defaultPen.Write(24);
            defaultPen.Write(50);

            greedyPen.Write(12);
            greedyPen.Write(24);
            greedyPen.Write(50);


            Console.WriteLine(defaultPen);
            Console.WriteLine(greedyPen);
        }
    }
}
