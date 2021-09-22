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

        public void ReturnShape(double angleA, double angleB, double angleC)
        {
            //check if can form triangle
            if (angleA == 0 || angleB == 0 || angleC == 0 )
            {
                Console.WriteLine("Unable to form any shape with the provided angles!");
                Console.WriteLine();
            }
            
            if ((angleA + angleB + angleC) > 180.0)
            {
                Console.WriteLine("Unable to form any shape with the provided angles!");
                Console.WriteLine();
            }

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
        public void ReturnShape(double angleA, double angleB, double angleC, double angleD)
        {
            //Check if able to form shape
            if ((angleA == 0 && angleB == 0) || (angleA == 0 && angleC == 0) ||
                   (angleB == 0 && angleC == 0) || (angleB == 0 && angleD == 0) ||
                   (angleC == 0 && angleD == 0) || (angleC == 0 && angleD == 0) ||
                   (angleD == 0 && angleA == 0))
            {
                Console.WriteLine("Unable to form any shape with the provided angles!");
                Console.WriteLine();
            }

            if ((angleA + angleB + angleC + angleD) > 360.0)
            {
                Console.WriteLine("Unable to form any shape with the provided angles!");
                Console.WriteLine();
            }

            //Check what kind of shapes
            if (angleA == 90.0 && angleB == 90.0 && angleC == 90.0 && angleD == 90.0)
            {
                Console.WriteLine("Are all 4 sides equal? (Y / N)");
                string ans = Console.ReadLine();
                Console.WriteLine();
                if (ans == "Y" || ans == "y")
                {
                    Console.WriteLine("The given angles can form a Square!");
                    Console.WriteLine();
                }
                else if (ans == "N" || ans == "n")
                {
                    Console.WriteLine("The given angles can form a Rectangle!");
                    Console.WriteLine();
                }
                else if (ans == "")
                {
                    Console.WriteLine("No entry detected! Nothing can be formed!");
                    Console.WriteLine();
                }
                else
                {
                   Console.WriteLine("Invalid answer! Nothing can be formed!");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The given angles can form a 4 sided polygon!");
                Console.WriteLine("Unfortunately, database does not have enough info to form a accurate deduction.");
                Console.WriteLine("Please check again in the future!");
                Console.WriteLine("Thank you!");
                Console.WriteLine();
            }
        }
    }
}
