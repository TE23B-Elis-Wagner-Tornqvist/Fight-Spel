
using System.Diagnostics.CodeAnalysis;

int HeroHP = 100;
int VillanHP = 100;
int runda = 1;

         Random random = new Random();
        int number = random.Next(1, 10);

        Random random1 = new Random();
        int number2 = random.Next(1, 10);


    while(true) {
    
    
    Console.WriteLine("Välkommen till spelet! Tryck på enter för att starta spelet!");

    Console.WriteLine("Vill du spela på hard, easy eller normal svårihetsgrad?");

    
    

    while (HeroHP > 0 && VillanHP > 0) {

    string mode = Console.ReadLine() ?? String.Empty;


    if(mode.ToLower() == "normal") {

        while (HeroHP > 0 && VillanHP > 0) {


       Console.WriteLine($"Runda {runda}!");
        elisDamage();
         NormalMode();
          runda++;
          Console.WriteLine("Tryck på enter för att börja nästa runda!");
          Console.ReadLine();
         Console.Clear();
        special();

         
        }

     }


     else if(mode.ToLower() == "hard") {

        while (HeroHP > 0 && VillanHP > 0) {

        
        Console.WriteLine($"Runda {runda}!");
        elisDamage();
         HardMode();
          runda++;
          Console.WriteLine("Tryck på enter för att börja nästa runda!");
          Console.ReadLine();
         Console.Clear();
         special();
        
        }

    }


    else if(mode.ToLower() == "easy") {

        while (HeroHP > 0 && VillanHP > 0) {

        
        Console.WriteLine($"Runda {runda}!");
        elisDamage();
         EasyMode();
          runda++;
          Console.WriteLine("Tryck på enter för att börja nästa runda!");
          Console.ReadLine();
         Console.Clear();
            special();
        }

    }


    Console.WriteLine($"Hjälten har {HeroHP} HP och Skurken har {VillanHP} HP");



   


         

    }
    

     if( HeroHP <= 0) {

        Console.WriteLine("Skurken vann!");

        slut();
        

    } else if(VillanHP <= 0) {

        Console.WriteLine("Hjälten vann!");

      slut();

    }




    

    



void elisDamage() {
        
        Random random = new Random();
        int Edamage = Random.Shared.Next(1, 15);
        VillanHP -= Edamage;
        Console.WriteLine($" Skurken skadades {Edamage} och har nu {VillanHP} kvar!");

    }

    void NormalMode() {

        Random random = new Random();
        int Tdamage = Random.Shared.Next(1, 15);
        HeroHP -= Tdamage;
        Console.WriteLine($" Hjälten skadades {Tdamage} och har nu {HeroHP} kvar!");

    }


    void HardMode() {

        Random random2 = new Random();
        int Hskurk = Random.Shared.Next(10, 30);
         HeroHP -= Hskurk;
        Console.WriteLine($" Hjälten skadades {Hskurk} och har nu {HeroHP} kvar!");
    }

    
    void EasyMode() {

         Random random3 = new Random();
        int Eskurk = Random.Shared.Next(1, 8);
         HeroHP -= Eskurk;
        Console.WriteLine($" Hjälten skadades {Eskurk} och har nu {HeroHP} kvar!");
    }

    void slut() {

          Console.WriteLine("Vill du spela igen?");
        string svar = Console.ReadLine() ?? string.Empty;
        if(svar.ToLower() == "ja") {

            HeroHP = 100;
            VillanHP = 100;
            runda = 1;


        } else if(svar.ToLower() == "nej") {

            Console.WriteLine("Synd! Du måste!");

        }

    }

        void special() {

             if(runda == 4) {

            Console.WriteLine("SPECIAL QUIZ ROUND!");
            Console.WriteLine($"Vad är {number} * {number2}?");

            string svar = Console.ReadLine() ?? string.Empty;

            if(svar == (number * number2).ToString()) {
                VillanHP -= 25;
                Console.WriteLine("Rätt svar! Skurken tog 25 CRITICAL HIT!");
            } else {
                HeroHP -= 25;
                Console.WriteLine("Fel svar! Du tar -25 CRITICAL HIT!");
            } 

            }


        }

    


    }