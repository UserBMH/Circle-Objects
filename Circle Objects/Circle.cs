using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Circle
    {

        public double radius;
        public double circumference;
        public double area;

        //They watch other methods return their values
        double cuckArea = 0;
        double cuckCircumference = 0;


        public Circle(double userRadius)
        {
            radius = userRadius;
        }
        
        //public string CalculateFormattedCircumference()
        //public string CalculateFormattedArea()
        //private string FormatNumber(double x)
       
        public double CalculateCircumference()
        {
            return double.Parse(CalculateFormattedCircumference());
        }

        public double CalculateArea()
        {
            return double.Parse(CalculateFormattedArea());
            
        }

        public string CalculateFormattedCircumference()
        {
            cuckCircumference = 2 * radius * Math.PI;
            return Math.Round(cuckCircumference, 2).ToString(); 

        }

        public string CalculateFormattedArea()
        {
            cuckArea = radius* radius *Math.PI;
            return Math.Round(cuckArea, 2).ToString();
        }


        //I dont know what this does as it doesn't seem to matter as I put the formula in the other methods?
        private string FormatNumber(double x)
        {
            return "1";
        }

        




    }
}





/*public Circle(double radius)
public double CalculateCircumference()
public string CalculateFormattedCircumference()
public double CalculateArea()
public string CalculateFormattedArea()
private string FormatNumber(double x)
*/