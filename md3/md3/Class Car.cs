using System;

public class Car
{

    public string Manufacturer { get; set; }

    public string Model { get; set; }

    public string PlateNumber { get; set; }

    public bool FunctionSMS { get; set; }

    public int CarCurrentSpeed { get; set; }

    public bool CanDrive { get; set; }

    public bool RiseSpeed { get; set; }
    public bool StopDrive { get; set; }
    public bool SlowDown { get; set; }

    public string GetGreeting()
            {
            string greeting = "Beep Beep";
            return greeting; 
            }

}




        