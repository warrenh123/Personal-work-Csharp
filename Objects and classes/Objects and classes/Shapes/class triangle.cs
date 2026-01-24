using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

public class Triangle
{
    public static int numberofTriangles; // static makes sure it is not for each object 
    public double s1, s2, s3; // these are the fields which are some properties of an object
    public double a1 //These angles are properties defined like a function but it isnt a method, so no () when calling it
    {
        get
        {
            double cosA = (s2*s2 + s3*s3 - s1*s1) / (2.0*s2*s3);
            return Math.Acos(cosA) * 180.0 / Math.PI;
        }
    }
    public double a2
    {
        get
        {
            double cosB = (s1*s1 + s3*s3 - s2*s2) / (2.0*s1*s3);
            return Math.Acos(cosB) * 180.0 / Math.PI;
        }
    }
    public double a3
    {
        get
        {
            double cosC = (s1*s1 + s2*s2 - s3*s3) / (2.0*s1*s2);
            return Math.Acos(cosC) * 180.0 / Math.PI;
        }
    }


    public Triangle(double a, double b, double c) // This is the constructor, lets you pass in values you need
    {
        this.s1 = a;
        this.s2 = b;
        this.s3 = c;
        numberofTriangles++;
    }
    
    public void describeTriangle()
    {
        Console.WriteLine($"The sides are {s1}, {s2}, {s3} and the angles are {a1}, {a2} and {a3}.");
    }

    public bool IsValidTriangle //also a property
    {
        get
        {
            double maxNumber = Math.Max(s1, Math.Max(s2,s3));
            if (maxNumber >= s1 + s2 || maxNumber >= s2 + s3 || maxNumber >= s1 + s3)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
    public bool IsRightAngled
    {
        get
        {
            if (a1 == 90 || a2 == 90 || a3 == 90) return true;
            else return false;
        }
    }

    public bool IsEquilateral()
    {
        if (a1 == 60 && a2 == 60 || a3 == 60 && a2 == 60 || a3 == 60 && a1 == 60)
        {
            return true;
        }
        else return false;
    }

    public bool IsIsosceles()
    {
        if(a1 == a2 || a2 == a3 || a1 == a3) return true;
        else return false;
    }

    public double Area()
    {
        double s = (s1 + s2 + s3) / 2;
        return Math.Sqrt(s * (s-s1) * (s-s2) * (s-s3));
    }


    
}