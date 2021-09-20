using System;

namespace md3
{
    class Program
    {
        static void Main(string[] args)
        {
                       
                     
          Console.WriteLine("Please, enter your First Name: ");
          string PublicFirstName =  Console.ReadLine();  //lai lietotājs ievadītu savu vārdu

          Console.WriteLine("Please, enter your Last Name: ");
          string PublicLasttName = Console.ReadLine();  //lai lietotājs ievadītu savu uzvārdu

            Console.WriteLine("Please, enter your Birth Date (MM-DD-YYYY) : ");
            string  PublicBirthDate = Console.ReadLine();  //lai lietotājs ievadītu savu dzimš. dat.

            Console.WriteLine("Please, enter your Hobby: ");
            string PublicHobby = Console.ReadLine();  //lai lietotājs ievadītu savu hobiju

            Console.WriteLine("Please, enter your Gender (male/ female) : ");

            string Gender = Console.ReadLine();  //lai lietotājs ievadītu savu dzimumu
            bool IsMale = Gender = IsMale; /// ??? Kā lai piefiksē, vai ir vai nav vīrietis pēc lietāja ievadītā, piem., Male? ???

            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            Console.WriteLine("The current date is {0}", date);


            // Vārds, Uzvārds, dzimšanas datums, hobijs, dzimums.




        }
    }
}
