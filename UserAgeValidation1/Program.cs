// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//rakendus küsib kasutajal sisestada tema vanus
// kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
// "you are too young to use instagram"
//muul juhul
//konsoolis kuvatakse "welcome to instagram"

Console.WriteLine("enter your age");

int userAge = int32. parse(Console.ReadLine()); //"13"-heap, rohkem ruumi võtaks, kui on lihtsalt 13-stack vähem vahemälu
if (userAge >= 13)
{
    Console.WriteLine("welcome to instagram!");
}
else (userAge < 13)
{
    Console.WriteLine("you are too young to use instagram.");
}