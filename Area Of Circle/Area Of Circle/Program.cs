using System;

namespace Area_Of_Circle
{
    class Program
    {
        static void Main(string[] args)
        {

             /* Write a program to calculate the area of a circle. The user will enter the radius of the circle 
                and the program will calculate and display the area according to the formula (area = 3.14 * 
                radius * radius). You must accept fractions as the input. If the user enters 1.2 for the radius 
                then the area will be 4.52. */ 
             
             //Input

            double radius, area;

            Console.Write("Enter The Radius:");

            //Processing

            radius = double.Parse(Console.ReadLine());
            area = 3.14 * radius * radius;

            //Output

            Console.WriteLine("The Area is " + area);

        }
    }
}
