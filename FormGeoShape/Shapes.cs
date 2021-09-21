using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGeoShape
{
    class Shapes
    {
        double angleA;
        double angleB;
        double angleC;
        double angleD;

        public Shapes(double angleA, double angleB, double angleC)
        {
            this.angleA = angleA;
            this.angleB = angleB;
            this.angleC = angleC;
        }

        public Shapes(double angleA, double angleB, double angleC, double angleD)
        {
            this.angleA = angleA;
            this.angleB = angleB;
            this.angleC = angleC;
            this.angleD = angleD;
        }

        public void returnShape(double angleA, double angleB, double angleC)
        {
            //Check for right angle
            if((angleA == 90.0) || (angleB == 90.0) || (angleC == 90.0))
            {
                Console.WriteLine("One side is a right angle, this is a Right Triangle.");
                Console.WriteLine();
            }

            //Check for Obtuse Triangle
            if (angleA > 90.0)
            {
                if(angleB < 90 && angleC < 90)
                {
                    Console.WriteLine("Only one side is more than 90 degrees, this is an Obtuse Triangle.");
                    Console.WriteLine();
                }
            }
            else if(angleB > 90.0)
            {
                if (angleA < 90 && angleC < 90)
                {
                    Console.WriteLine("Only one side is more than 90 degrees, this is an Obtuse Triangle.");
                    Console.WriteLine();
                }
            }
            else if (angleC > 90.0)
            {
                if (angleA < 90 && angleB < 90)
                {
                    Console.WriteLine("Only one side is more than 90 degrees, this is an Obtuse Triangle.");
                    Console.WriteLine();
                }
            }

            //Check for Acute Triangle
            if(angleA < 90.0 && angleB < 90.0 && angleC < 90.0)
            {
                Console.WriteLine("All three angles are below 90 degrees, this is a Acute Triangle.");
                Console.WriteLine();    
            }

            //Check for Scalene Triangle
            if(angleA != angleB && angleA != angleC && angleB != angleC)
            {
                Console.WriteLine("All 3 angles are not the same, this is also a Scalene Triangle");
                Console.WriteLine();
            }

            //Check for Isosceles Triangle
            if(angleA == angleB && angleB != angleC)
            {
                Console.WriteLine("2 angles are of the same, this is an Isoceles Triangle");
                Console.WriteLine();
            }else if(angleB == angleC && angleC != angleA)
            {
                Console.WriteLine("2 angles are of the same, this is an Isoceles Triangle");
                Console.WriteLine();
            }

            //Checkfor Eequilateral Triangle
            if(angleA == 60.0 && angleB == 60.0 && angleC == 60.0)
            {
                Console.WriteLine("All angles are at 60 degrees, this is an Equilateral Triangle.");
                Console.WriteLine();
            }
        }
        public void returnShape(double angleA, double angleB, double angleC, double angleD)
        {

        }
    }
}
