using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGeoShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Angles here... ");
            Console.WriteLine();
            Console.Write("Enter First Angle: ");
            double input1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Do you wish to add another angle? (Y / N)");
            string ans1 = Console.ReadLine();
            Console.WriteLine();

            if(ans1 == "Y" || ans1 == "y")
            {
                Console.Write("Enter Second Angle: ");
                double input2 = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Do you wish to add another angle? (Y / N)");
                string ans2 = Console.ReadLine();
                Console.WriteLine();

                if (ans2 == "Y" || ans2 == "y")
                {
                    Console.Write("Enter Third Angle: ");
                    double input3 = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Do you wish to add another angle? (Y / N)");
                    string ans3 = Console.ReadLine();
                    Console.WriteLine();

                    if (ans3 == "Y" || ans3 == "y")
                    {
                        Console.Write("Enter Fourth Angle: ");
                        double input4 = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Shapes nShape = new Shapes(input1, input2, input3,input4);
                        Console.WriteLine("The angles you have given are: " + input1 + ", " + input2 + ", " + input3 + ", " + input4);
                        nShape.ReturnShape(input1, input2, input3, input4);

                    }
                    else if (ans3 == "N" || ans3 == "n")
                    {
                        Shapes nShape = new Shapes(input1, input2, input3);
                        Console.WriteLine("The angles you have given are: " + input1 + ", " + input2 + ", " + input3);
                        nShape.ReturnShape(input1,input2,input3);
                    }
                    else if (ans3 == "")
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
                else if (ans2 == "N" || ans2 == "n")
                {
                    Console.WriteLine("No shape can be formed with the given angles!");
                    Console.WriteLine();
                }
                else if (ans2 == "")
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
            else if(ans1 == "N" || ans1 == "n")
            {
                Console.WriteLine("No shape can be formed with only 1 angle!");
                Console.WriteLine();
            }
            else if (ans1 == "")
            {
                Console.WriteLine("No entry detected! Nothing can be formed!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid answer! Nothing can be formed!");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
