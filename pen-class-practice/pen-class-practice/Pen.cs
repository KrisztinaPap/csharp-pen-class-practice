using System;
using System.Collections.Generic;
using System.Text;

namespace pen_class_practice
{
    class Pen
    {
        public string Brand { get; set; }

        public string Colour { get; set; }

        private double _inkLevel;
        public double InkLevel 
        {
            get
            {
                return _inkLevel;
            }
            set
            {
                if (value < 0 || value > MaxInk)
                {
                    throw new Exception("Ink level must be between zero and maximum ink level.");
                }
                _inkLevel = value;
            }
        }

        public double MaxInk { get; set; }

        public bool HasInk { get; set; }

    }
}
