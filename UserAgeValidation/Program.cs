// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Alex!");
//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tevitab kasutajat järgmiselt:

Console.WriteLine("Please select your gender (m/f):");

char userGender = char.Parse(Console.ReadLine()); //loeab konsoolist maha andmeid string formaadis
Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}