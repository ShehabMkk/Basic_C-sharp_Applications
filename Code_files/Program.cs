//============================================================================================\\
//===================================Assignment_08============================================\\
//============================================================================================\\

namespace Assignment_08;
using System;
using System.Linq;

#region FirstProject
public class Point3D : IComparable<Point3D>, ICloneable
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point3D() : this(0, 0, 0) { }

    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return $"Point Coordinates: ({X}, {Y}, {Z})";
    }

    public static bool operator ==(Point3D p1, Point3D p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
    }

    public static bool operator !=(Point3D p1, Point3D p2)
    {
        return !(p1 == p2);
    }

    public int CompareTo(Point3D other)
    {
        if (X != other.X)
            return X.CompareTo(other.X);
        else
            return Y.CompareTo(other.Y);
    }

    public object Clone()
    {
        return new Point3D(X, Y, Z);
    }

    public override bool Equals(object obj)
    {
        return obj is Point3D point && this == point;
    }

    public override int GetHashCode()
    {
        return (X, Y, Z).GetHashCode();
    }
}
#endregion

//============================================================================================\\

#region SecondProject
public interface IShape
{
    double Area { get; }
    void DisplayShapeInfo();
}

public interface ICircle : IShape { }
public interface IRectangle : IShape { }

public class Circle : ICircle
{
    public double Radius { get; set; }

    public double Area => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Circle with Radius: {Radius}, Area: {Area}");
    }
}

public class Rectangle : IRectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double Area => Length * Width;

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Rectangle with Length: {Length}, Width: {Width}, Area: {Area}");
    }
}
#endregion

//============================================================================================\\

#region ThirdProject
public class Duration
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Duration(int totalSeconds)
    {
        Hours = totalSeconds / 3600;
        totalSeconds %= 3600;
        Minutes = totalSeconds / 60;
        Seconds = totalSeconds % 60;
    }

    public override string ToString()
    {
        return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
    }

    public override bool Equals(object obj)
    {
        return obj is Duration duration &&
               Hours == duration.Hours &&
               Minutes == duration.Minutes &&
               Seconds == duration.Seconds;
    }

    public override int GetHashCode()
    {
        return (Hours, Minutes, Seconds).GetHashCode();
    }

    public static Duration operator +(Duration d1, Duration d2)
    {
        int totalSeconds = d1.ToSeconds() + d2.ToSeconds();
        return new Duration(totalSeconds);
    }

    public static Duration operator +(Duration d1, int seconds)
    {
        return new Duration(d1.ToSeconds() + seconds);
    }

    public static Duration operator +(int seconds, Duration d1)
    {
        return new Duration(d1.ToSeconds() + seconds);
    }

    public static Duration operator ++(Duration d)
    {
        return d + 60;
    }

    public static Duration operator --(Duration d)
    {
        return d + (-60);
    }

    public static Duration operator -(Duration d1, Duration d2)
    {
        int totalSeconds = d1.ToSeconds() - d2.ToSeconds();
        return new Duration(totalSeconds);
    }

    public static bool operator >(Duration d1, Duration d2)
    {
        return d1.ToSeconds() > d2.ToSeconds();
    }

    public static bool operator <(Duration d1, Duration d2)
    {
        return d1.ToSeconds() < d2.ToSeconds();
    }

    public static bool operator >=(Duration d1, Duration d2)
    {
        return d1.ToSeconds() >= d2.ToSeconds();
    }

    public static bool operator <=(Duration d1, Duration d2)
    {
        return d1.ToSeconds() <= d2.ToSeconds();
    }

    public static explicit operator DateTime(Duration d)
    {
        return new DateTime().AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
    }

    private int ToSeconds()
    {
        return Hours * 3600 + Minutes * 60 + Seconds;
    }
}
#endregion

//============================================================================================\\

class Program
{
    static void Main(string[] args)
    {
        #region FirstProject
        Point3D p1 = new Point3D(10, 20, 30);
        Point3D p2 = new Point3D(10, 20, 30);
        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
        Console.WriteLine(p1 == p2);

        Point3D[] points = { new Point3D(5, 6, 7), new Point3D(2, 3, 4), new Point3D(8, 9, 10) };
        Array.Sort(points);
        foreach (var point in points)
        {
            Console.WriteLine(point);
        }
        #endregion

        //====================================================================================\\

        #region SecondProject
        Circle circle = new Circle(5);
        circle.DisplayShapeInfo();

        Rectangle rectangle = new Rectangle(4, 6);
        rectangle.DisplayShapeInfo();
        #endregion

        //====================================================================================\\
        
        #region ThirdProject
        Duration d1 = new Duration(1, 10, 15);
        Duration d2 = new Duration(7800);
        Duration d3 = new Duration(666);

        Console.WriteLine(d1.ToString());
        Console.WriteLine(d2.ToString());
        Console.WriteLine(d3.ToString());

        Duration d4 = d1 + d2;
        Console.WriteLine(d4.ToString());

        d3 = ++d1;
        Console.WriteLine(d3.ToString());

        d3 = --d2;
        Console.WriteLine(d3.ToString());

        Console.WriteLine(d1 > d2);
        Console.WriteLine(d1 <= d2);

        DateTime dt = (DateTime)d1;
        Console.WriteLine(dt);
        #endregion
    }
}
