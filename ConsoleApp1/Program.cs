
static void glurb()
{
    string[] names = ["Mjölk", "Smör", "Ost", "Bröd", "Gurka"];
int r = Random.Shared.Next(101);
 string[] vickt = ["12", "28", "34", "40", "50"];

for (int i = 0; i < 1; i++)
{
    Console.Write(names[0]);  
    Console.Write(" väger ");
    Console.WriteLine(vickt[0]);

    Console.Write(names[1]);  
    Console.Write(" väger ");
    Console.WriteLine(vickt[1]);
    
    Console.Write(names[2]);  
    Console.Write(" väger ");
    Console.WriteLine(vickt[2]);

     Console.Write(names[3]);  
    Console.Write(" väger ");
    Console.WriteLine(vickt[3]);

    Console.Write(names[4]);  
    Console.Write(" väger ");
    Console.WriteLine(vickt[4]);
}
int points = 0;
string pointsText = Console.ReadLine();
bool success = int.TryParse(pointsText, out points);


// Körs så många gånger som behövs för att 
// användaren ska förstå att hen ska skriva "Micke"
while (points < 1)
{
  Console.WriteLine("Skriv hur mycket du kan bära i kg bara numer:");
  pointsText = Console.ReadLine();
  bool succes = int.TryParse(pointsText, out points);
}

if (points > 13) 
{    
    Console.WriteLine("du kan lyfta mjölken");
}
if (points > 29)
{
    Console.WriteLine("du kan lyfta smöret");
}
if (points > 35) 
{    
    Console.WriteLine("du kan lyfta osten");
}
if (points > 41)
{
    Console.WriteLine("du kan lyfta Brödet");
}
if (points > 51)
{
    Console.WriteLine("du kan lyfta gurkan");
}


}

glurb();





Console.ReadLine();
