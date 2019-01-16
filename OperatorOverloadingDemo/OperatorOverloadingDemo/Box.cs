using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloadingDemo
{
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public static Box operator+ (Box a, Box b)
        {
            return new Box
            {
                Width = a.Width + b.Width,
                Height = a.Height + b.Height,
                Length = a.Length + b.Length
            };
        }

        public static Box operator+ (Box a, double b)
        {
            return new Box
            {
                Width = a.Width + b,
                Length = a.Length,
                Height = a.Height
            };
        }

        public static bool operator< (Box a, Box b)
        {
            return (a.Length < b.Length);

        }

        public static bool operator> (Box a, Box b)
        {
            return (a.Length > b.Length);
        }


        public static bool operator== (Box lhs, Box rhs)
        {
            return (lhs.Length == rhs.Length) && (lhs.Width == rhs.Width) && (lhs.Height == rhs.Height);
        }

        public static bool operator !=(Box lhs, Box rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Box))
                return false;
            return this == (obj as Box);
        }

    }
}
