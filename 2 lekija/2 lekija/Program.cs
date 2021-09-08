using System;

namespace _2_lekija
{
    class Program
    {
        static void Main(string[] args)
        {

            int Telefons = 22334455;
            char nosaukums = 'E';
            string teksts = "te var daudz ierakstīt";
            int aprēķins = 2 + 2 * 2;
            bool jānē = true;
            double skaitlis = 2.3333;
            string V = "te pa vidu ir jauna rinda";
            string tukšarinda = "";
            int cip = 6;
            cip++;
            int A = 100;
            int B = 2;
            int C = A % B;




            Console.WriteLine(Telefons);
            Console.WriteLine(nosaukums);
            Console.WriteLine(teksts);
            Console.WriteLine(aprēķins);
            Console.WriteLine(jānē);
            Console.WriteLine(skaitlis);
            Console.WriteLine(V);
            Console.WriteLine(tukšarinda);
            Console.WriteLine(V);
            Console.WriteLine(cip);
            Console.WriteLine(C);

            //-----------

            int number1 = 15;
            int number2 = 14;
            int number3 = number1 + number2;
            bool A1 = number1 != number2;
            bool A2 = number1 > number2;
            Console.WriteLine(number3);
            Console.WriteLine(A1);

            Console.WriteLine(A1 && A2);

            bool G = true;
            bool M = false;
            bool both = G || M;
            bool H = !M;
            bool otradi = G && H;
            Console.WriteLine(otradi);
         ;
            ;


            // --------

            Console.WriteLine("Kāds ir Tavs vecums?");
            string ageText = Console.ReadLine(); //readline nozīmē, ka aplikācijā būs jāievada kaut kas un jānospiež Enter
            int age = int.Parse(ageText); //pārveido tekstu par skaitli, ja var, t.i., ja tas teksts tiešām ir skaitlis
            Console.WriteLine("Tev ir tik un tik gadi " + ageText);
            int age2 = -age;  //atgriež ar mīnusa zīmi priekšā
            Console.WriteLine("Tev ir tik un tik gadi " + age2);

            //-----------------------------

            int maxnum1 = 4;
            int maxnum2 = 6;
            int maxres = Math.Max(maxnum1, maxnum2);
            Console.WriteLine(maxres);
            
            Console.WriteLine(maxres);


            double f = 4.44;
            double rounded = Math.Truncate(f);
            Console.WriteLine(rounded);

        }
    }
}

