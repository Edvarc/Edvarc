using System;

namespace klases_darbs_4_lekcija
{
    class Program
    {
        static void Main(string[] args)

        {
            //  bool isTrue = true;
            //  if (isTrue) = true
            //           { Console.WriteLine("tekst"); }

            //  else
            //   { Console.WriteLine("cits teksts"); }

            //   int age = 70;
            //  if (age < 18)
            //    { Console.WriteLine("Tu esi jaunietis"); }
            //     else if (age >= 70)
            //  { Console.WriteLine("Pensionārs)"; }
            //    else {Console.WriteLine("Tu esi darbspējīgā vecumā)"; }

            int abcde = int.Parse(Console.ReadLine());
            switch (abcde)
            {
                case 1:   // te salīdzina, vai pie case minētais skaitlis ir tas, kas ir augšā pie svitča
                    Console.WriteLine("Case1");
                    break;

                case 2:
                    Console.WriteLine("Case2");
                    break;
                case 3:
                    Console.WriteLine("Case3");
                    break;

                default:
                    Console.WriteLine("kaut kas cits");
                    break;


            }

            string name = "Artis";
         
            switch (name)
            {
                case "a":   // te salīdzina, vai pie case minētais skaitlis ir tas, kas ir augšā pie svitča
                    Console.WriteLine("Case1");
                    break;

                case "b":
                    Console.WriteLine("Case2");
                    break;
                case "Artis":
                    Console.WriteLine("Case3");
                    break;

                default:
                    Console.WriteLine("kaut kas cits");
                    break;


            }



        }
    }
}
