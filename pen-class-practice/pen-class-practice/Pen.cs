using System;
using System.Text;

namespace pen_class_practice
{
    class Pen
    {
        public string Brand { get; set; }
        public string Colour { get; set; }
        public double MaxInk { get; set; }

        private double _inkLevel;
        public double InkLevel 
        {
            get
            {
                return _inkLevel;
            }
            set
            {
                try
                {
                    if ( (value < 0) || (value > MaxInk) )
                    {
                        throw new Exception("Ink level must be more than zero and less than the maximum ink level.");
                    }
                    _inkLevel = value;
                }
               
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }
        }
        public bool HasLid { get; set; }
 
        // Default constructor
        public Pen()
        {
            Brand = "Bic";
            Colour = "black";
            MaxInk = 100;
            InkLevel = 75;
            HasLid = true;
        }
        // Greedy constructor
        public Pen(string brand, string colour, double maxInk, double inkLevel, bool hasLid)
        {
            Brand = brand;
            Colour = colour;
            MaxInk = maxInk;
            InkLevel = inkLevel;
            HasLid = hasLid;
        }

        public void Write()
        {
            InkLevel = InkLevel-(10 * 0.05);
            Console.WriteLine($"After Write() -> New ink level: {InkLevel} mL");
        }

        public void Write(int charCount)
        {
            InkLevel = InkLevel-(charCount * 0.05);
            Console.WriteLine($"After Write({charCount}) -> New ink level: {InkLevel} mL");
        }
        // Citation:
        // https://blog.submain.com/c-constructor-usage-examples-best-practices/
        public override string ToString()
        {
            // Refactored at Lindsey Graham's suggestion! Thank you!
            string lidText = (HasLid == true) ? "with" : "without";
            double percentageText = Math.Round((((MaxInk - InkLevel) / MaxInk) * 100) / 5) * 5;
            return $"This is a {Colour} {Brand} pen {lidText} a lid with approximately {percentageText}% of the ink remaining.";

/*          StringBuilder sb = new StringBuilder($"This is a {Colour} pen ");
            sb.Append( (HasLid == true ) ? "with" : "without");
            sb.Append($" a lid with approximately ");
            sb.Append(Math.Round((((MaxInk - InkLevel) / MaxInk) * 100)/5)*5);
            sb.Append("% of the ink remaining.");
            return sb.ToString();*/
            
        }

       
    }
}
