using System;

public class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int Lanes { get; set; }
    public int TrafficLevel { get; set; }

    public Road(double length, double width, int lanes)
    {
        Length = length;
        Width = width;
        Lanes = lanes;
        TrafficLevel = 0;
    }
}
