using System;

namespace md3
{
    class Program_Car
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = car;


        } 
    } 
}



    //2. uzdevums - Mašīna
//Izveidot klasi mašīna.Mašinai ir marka, nummurzīme un ātrums.Mašīna māk sākt braukt, palielināt ātrumu, beigt braukt, samazināt ātrumu. Mašīna māk arī uztaurēt (Izvada konsolē "Beep beep")

 /*

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




        