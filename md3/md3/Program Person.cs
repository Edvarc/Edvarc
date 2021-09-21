using System;

namespace md3
{
    class Program
    {
        static void Main(string[] args)
        {



            // Declaring an object of type MyClass.
//MyClass mc = new MyClass();

            //Declaring another object of the same type, assigning it the value of the first object.
            //MyClass mc2 = mc;

            Console.WriteLine("Please, enter your First Name: ");

            Person person = new Person();
            Person person2 = person;
            // šīs divas augšējās rindas kaut kā sasaista Class Person ar šo Class Program un tad te zemāk vairs nav jāraksta lauku tips (string, bool utt.).
            person.PublicFirstName  =  Console.ReadLine();  //lai lietotājs ievadītu savu vārdu

          Console.WriteLine("Please, enter your Last Name: ");
          person.PublicLastName  = Console.ReadLine();  //lai lietotājs ievadītu savu uzvārdu
          

            Console.WriteLine("Please, enter your Birth Date (yyyy/mm/dd) : ");
            string PublicBirthDate = Console.ReadLine();  //lai lietotājs ievadītu savu dzimš. dat.
            System.Globalization.CultureInfo cultureinfo = new System.Globalization.CultureInfo("ja-JP");
            DateTime PublicBirthDateParse = DateTime.Parse(PublicBirthDate, cultureinfo);                    
            Console.WriteLine(PublicBirthDateParse); //izdod ārā ievadīto dz. d. datumu   16/07/1987 00:00:00

            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
                            
                Console.WriteLine("   Local date and time: {0}, {1:G}",
                                  localDate.ToString(cultureinfo), localDate.Kind);

             var AgeofPerson = localDate - PublicBirthDateParse;
            Console.WriteLine("Your age is: " + AgeofPerson);
           
            Console.WriteLine("Please, enter your Hobby: ");
            person.PublicHobby = Console.ReadLine();  //lai lietotājs ievadītu savu hobiju

            //Console.WriteLine("Please, enter your Gender (male/ female) : ");

           // person.PublicIsMale = Console.ReadLine();  //lai lietotājs ievadītu savu dzimumu
            //person.IsMale = true; /// ??? Kā lai piefiksē, vai ir vai nav vīrietis pēc lietāja ievadītā, piem., Male? ???

          //  string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
          //  Console.WriteLine("The current date is {0}", date);


            // Vārds, Uzvārds, dzimšanas datums, hobijs, dzimums.




        }
    }
}
