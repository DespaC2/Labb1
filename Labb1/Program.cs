//+Ta textsträng som argument till Main (redan inskrivet eller från användare som matar in den i konsollen.

// String värdet
string Textstring = "29535123p48723487597645723645";

//om man vill ha en kustom sträng istället för den ovan (kommentera ut strängen ovan isf)
//Console.WriteLine("Skriv in en string");
//string Textstring = Console.ReadLine();

//Värdet som sammlar in alla delsträngar och summerar dom
long Alltsumma = 0;

//en bool som används för att skippa igenom en loop om värdet blir true
bool reset = false;

//delsträngs värdet som ändras under loopen
string delsträng = "";

//loopen kollar igenom det första indexet av stringen (sedan nästa index)
for (int i = 0; i < Textstring.Length; i++)
{
    //kollar om värdet är ett nummer
    if (char.IsDigit(Textstring[i]))
    {
    // lägger till värdet från textstring till delsträng
        delsträng += Textstring[i];
      
        for (int j = i + 1; j < Textstring.Length; j++)
        {
            
            if (char.IsDigit(Textstring[j]))
            {
                delsträng += Textstring[j];
                // kollar om första och sista värdet är lika. om det är det så läggs det till i alltsumma och börjar om loopen
                if (Textstring[i] == Textstring[j])
                {
                    //gör om delsträng till en int och plussar på den till alltsumma
                    long.TryParse(delsträng, out long ny);
                    Alltsumma += ny;
                    break;
                }
            }
            //bryter loopen om den hittar ett värde som inte är ett nummer
            else
            {
                break;
            }
        }
       
    }


    //om delsträngen inte börjar och slutar på samma siffra så tas delsträngen bort
    if (delsträng.Length < 2 || delsträng[0] != delsträng[delsträng.Length - 1])
    {
        delsträng = "";
    }
    else
    {
        // om delsträngen har samma start och slut siffra så färgas den om 
        ConsoleColor originalColor = Console.ForegroundColor;

        //gör en int som ska hitta vart delsträng är i textstring
        int startIndex = Textstring.IndexOf(delsträng);

        //skriver ut början av textsträngen till delsträngen kommer fram
        Console.Write(Textstring.Substring(0, startIndex));

        //byter delsträngens färg till magenta och sen tillbaka till den ordinarie färgen
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(delsträng);
        Console.ForegroundColor = originalColor;

        //skriver ut rästen av strängen efter delsträngs delen
        Console.WriteLine(Textstring.Substring(startIndex + delsträng.Length));
        
        //resetar delsträngen
        delsträng = "";
    }
}
//skriver ut den totala summan av delsträngarna
Console.WriteLine("Den totala summan är: " + Alltsumma);























//string ny = "";
//string delsumma = "2";
//for (int i = 0; i < Textstring.Length; i++)
//{
//    char ch = Textstring[i];

//    if (delsumma.Contains(ch))
//    {
//        ny += "*";
//    }
//    else
//    {
//        ny += ch;
//    }


//}
//Console.WriteLine(ny);
//- Sök igenom textsträngen efter alla delsträngar som börjar/slutar på samma siffra.


//- Se till att det inte finns start/slutsiffra, ord eller andra tecken mellan dem. ex (487684 inte 489747p984).

//-Skriv ut sträng raden med delsträngen markerad. 

//+ Delsträngarna ska vara markerade med valfri färg.

//- Fortsätt söka efter delsträngar efter förgående sträng nummer och repetera stegen ovan.

//+ Addera in varenda delsträng i en sträng

//+ Skriv ut det summerade talet.
//29535123p48723487597645723645