using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2D
{
    class Vector2D
    {
        private double x;
        private double y;
        private double tempx;
        private double tempy;
        public double degrees;
        public double mag;

        public double X {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Vector2D(double xParameter, double yParameter)
        {
            X = xParameter;
            tempx = xParameter;
            Y = yParameter;
            tempy = yParameter;
        }
        // Method to negate X and Y Values
        public void negateX()
        {
            X = tempx * -1;
        }
        public void negateY()
        {
            Y = tempy * -1;
        }
        // Method to add Vectors.
        public void addVector(double xParameter, double yParameter)
        {
            X = tempx + xParameter;
            Y = tempy + yParameter;
        }
        // Method to subtract vectors.
        public void subtractVector(double xParameter, double yParameter)
        {
            X = tempx - xParameter;
            Y = tempy - yParameter;
        }
        // Method to multiply the vector by the scalar.
        public void scalarMultiplication(double scalar)
        {
            X = scalar * tempx;
            Y = scalar * tempy;
        }
        // Method to calculate the magnitude of the vector . ( magnitude = Square root of( X * X ) +( Y * Y )
        public double getMagnitude()
        {
            mag = Math.Sqrt((tempx * tempx) + (tempy * tempy));
            return mag;
        }
        // Method to calculate the angle of the vector in degrees. ( arc tan of ( y/x) )
        public double getDegrees()
        {
           degrees = Math.Atan2(tempy , tempx) * 180 / Math.PI;
            return degrees;
        }

        public void Normalize()
        {
            mag = Math.Sqrt((tempx * tempx) + (tempy * tempy));
            if (mag > 0) { 
                X = tempx / mag;
                Y = tempy / mag;
            }
            else
            {
                return;
            }
        }
        public double getDot(double xParameter, double yParameter)
        {
            X = tempx * xParameter;
            Y = tempy * yParameter;
        }
        //public double GetAngleBetweenVector(Vector2D otherVector)
        //public void Lerp(Vector2D otherVector, double t)
        //public void RotateVector(double angle)


        // This is a method to show the vector in the correct way (x , y)
        public override string ToString()
        {
            return "(" + X.ToString() + "," + Y.ToString() + ")";
        }
    }
}
