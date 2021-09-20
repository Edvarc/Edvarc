using System;
using ConsoleApp1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new   Person    ("Artis");  //new person ir kā objekts. Tam ir reference uz noteiktu vietu atmiņā. 
            Person person2 = person;
            // person.Name = "Artis";
            person.Age = 20;
            person.IsMale = true;
            person.Money = 222.33;
            person.Initial = 'A';

            person2.Age = 26; // tā kā ir tikai viena new person, tad person2 te pārraksta person vecumu
            string greeting = person.GetGreeting();  //ja ir iekavas, tad  tas nozīmē, ka ir darīšana ar kaut kādu funkciju;
           
            Console.WriteLine(greeting);
        }
    }
}

