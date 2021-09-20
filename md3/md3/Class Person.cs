using System;


//  4.uzdevums - Persona
//  Izveidot klasi persona.  DARĪTS!
//  Pesonai ir Vārds, Uzvārds, dzimšanas datums, hobijs, dzimums.    DARĪTS!
//  Iegūstam personas visus datus no lietotāja.
//    Izveidojam funkcijas, ka persona māk sasveicināties un zin aprēķināt cik personai ir gadi.
//    Persona sasveicinās aptuveni pēc parauga "Hello my name is {name} {surname} and I am {yearsOld}"
//    Pēc personas izveides personas sveiciens tiek izvadīts konsolē


public class Person
{
    private String PrivateFirstName;
    private String PrivateLastName;
    private DateTime PrivateBirthDate;
    private String PrivateHobby;
    private bool PrivateIsMale;

    public String PublicFirstName
    {
        get { return PrivateFirstName; }
        set { PrivateFirstName = value; }
    }
    public String PublicLastName
    {
        get { return PrivateLastName; }
        set { PrivateLastName = value; }
    }

    public DateTime PublicBirthDate
    {
        get { return PrivateBirthDate; }
        set { PrivateBirthDate = value; }
    }

    public String PublicHobby
    {
        get { return PrivateHobby; }
        set { PrivateHobby = value; }
    }

    public bool PublicIsMale
    {
        get { return PrivateIsMale; }
        set { PrivateIsMale = value; }
    }

}

        