
using System.Diagnostics.CodeAnalysis;

int elisHP = 100;
int teoHP = 100;
int runda = 1;

         Random random = new Random();
        int number = random.Next(1, 10);

        Random random1 = new Random();
        int number2 = random.Next(1, 10);


    while(true) {
    
    
    Console.WriteLine("Välkommen till spelet! Tryck på enter för att starta spelet!");

    Console.ReadLine();

    Console.WriteLine($"Elis har {elisHP} HP och Teo har {teoHP} HP");



    while (elisHP > 0 && teoHP > 0) {

        Console.WriteLine($"Runda {runda}!");
        elisDamage();
         teoDamage();
          runda++;
          Console.WriteLine("Tryck på enter för att börja nästa runda!");
          Console.ReadLine();

          Console.Clear();


          if(runda == 4) {

            Console.WriteLine("SPECIAL QUIZ ROUND!");
            Console.WriteLine($"Vad är {number} * {number2}?");

            string svar = Console.ReadLine() ?? string.Empty;

            if(svar == (number * number2).ToString()) {
                teoHP -= 25;
                Console.WriteLine("Rätt svar! Teo tog 25 CRITICAL HIT!");
            } else {
                elisHP -= 25;
                Console.WriteLine("Fel svar! DU TAR -25 CRITICAL HIT!");
            } 

            }

          }
        

     if( elisHP <= 0) {

        Console.WriteLine("Teo vann!");

        Console.WriteLine("Vill du spela igen?");
        string svar = Console.ReadLine() ?? string.Empty;
        if(svar.ToLower() == "ja") {

            elisHP = 100;
            teoHP = 100;
            runda = 1;

        } else if(svar.ToLower() == "nej") {

            break;

        }
        

    } else if(teoHP <= 0) {

        Console.WriteLine("Elis vann!");

        Console.WriteLine("Vill du spela igen?");
        string svar = Console.ReadLine() ?? string.Empty;
        if(svar.ToLower() == "ja") {

            elisHP = 100;
            teoHP = 100;
            runda = 1;

        } else if(svar.ToLower() == "nej") {

            break;

        }

    }




    }

void elisDamage() {

        Random random = new Random();
        int Edamage = Random.Shared.Next(1, 20);
        teoHP -= Edamage;
        Console.WriteLine($" teo tog {Edamage} och har nu {teoHP} kvar!");

    }

    void teoDamage() {

        Random random = new Random();
        int Tdamage = Random.Shared.Next(1, 20);
        elisHP -= Tdamage;
        Console.WriteLine($" elis tog {Tdamage} och har nu {elisHP} kvar!");

    }

    

    
