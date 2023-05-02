// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Auli!");

//rakendus küsib kasutajalt valida tema sugu(m/f)
//raskendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"welcome, mr. [kasutaja perekonnnanimi]" / "welcome, ms. [kasutaja perekonnanimi]"

Console.WriteLine("please, select your gender (m/f):");

char userGender =char.Parse(Console.ReadLine());//loeb konsoolist maha andmeid, string=sõne formaadis
Console.WriteLine("please, enter your last name:");
string userLastname = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"welcome, mr. {userLastname}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"welcome, ms. {userLastname}!");
}
else
{
    Console.WriteLine($"welcome {userLastname}!");
}

