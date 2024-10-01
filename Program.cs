
using System.Diagnostics.CodeAnalysis;

int heroHp = 100;
int villanHp = 100;
int round = 1;

Random random = new Random();
int number = random.Next(1, 10);
                                             // dessa skapar ett random nummer som jag sedan använder i multiplikation
Random random1 = new Random();
int number2 = random.Next(1, 10);


while (true)
{



    Console.WriteLine("Välkommen till spelet! Tryck på enter för att starta spelet!");

    Console.WriteLine("Vill du spela på hard, easy eller normal svårihetsgrad? Och vilken character vill du spela med, tank, sniper eller shooter?");

    string mode = Console.ReadLine() ?? String.Empty;
    string character = Console.ReadLine() ?? String.Empty;

    if (mode.ToLower() == "hard" && character.ToLower() == "tank")
    {
        heroHp = 225;         // ifall man väljer "hard" svårighetsgrad och tank som gubbe så får man 300hp
    }

    if (mode.ToLower() == "hard" && character.ToLower() == "sniper")
    {

        heroHp = 20;  // hard och sniper = 20hp
    }

    if (mode.ToLower() == "hard" && character.ToLower() == "shooter")
    {

        heroHp = 100;      // hard och shooter = 100hp
    }

    if (mode.ToLower() == "normal" && character.ToLower() == "tank")
    {
        heroHp = 225;     // normal och tank = 300hp
    }

    if (mode.ToLower() == "normal" && character.ToLower() == "sniper")
    {

        heroHp = 20;
    }

    if (mode.ToLower() == "normal" && character.ToLower() == "shooter")
    {

        heroHp = 100;
    }

    if (mode.ToLower() == "easy" && character.ToLower() == "tank")
    {
        heroHp = 225;
    }

    if (mode.ToLower() == "easy" && character.ToLower() == "sniper")
    {

        heroHp = 20;
    }

    if (mode.ToLower() == "easy" && character.ToLower() == "shooter")
    {

        heroHp = 100;
    }




    while (heroHp > 0 && villanHp > 0)
    {




        Console.WriteLine($"Runda {round}!");
        if (character.ToLower() == "tank")
        {
            Tank();              // ifall man väljer tank så får man properties av tank() funktionen, vilket betyder mer health mindre skada
        }

        if (character.ToLower() == "sniper")
        {

            Sniper();          // samma som på tank  fast för sniper properties
        }

        if (character.ToLower() == "shooter")
        {

            ElisDamage();       // samma som tank fast för shooter properties (som heter ElisDamage, dåligt namn)
        }

        if (mode.ToLower() == "normal")
        {
            NormalMode();
            round++;
            Console.WriteLine("Tryck på enter för att börja nästa runda!");       // ifall man valde noraml så får enemy en visss health och gör en viss skada
            Console.ReadLine();
            Console.Clear();
            // special();
        }






        else if (mode.ToLower() == "hard")
        {

            HardMode();
            round++;
            Console.WriteLine("Tryck på enter för att börja nästa runda!");  //hard = en viss enemy health och skada
            Console.ReadLine();
            Console.Clear();
            Special();  // hard har även en speciel funktion där det är en quix runda


        }











        else if (mode.ToLower() == "easy")
        {

            EasyMode();
            round++;
            Console.WriteLine("Tryck på enter för att börja nästa runda!");    // samma som de andra, easy = en viss health och skada
            Console.ReadLine();
            Console.Clear();
            //special();


        }


        Console.WriteLine($"Hjälten har {heroHp} HP och Skurken har {villanHp} HP");








    }


    if (heroHp <= 0 && villanHp <= 0)
    {

        Console.WriteLine("OAVGJORT");       // om de både har 0 eller mindre så blir det oavgjort 
        End();                              // då sker också end funktionen vilket är en funktion där spelaren får välja om de vill köra igen

    }

    if (heroHp <= 0)
    {


        Console.WriteLine("Skurken vann!");

        End();


    }
    else if (villanHp <= 0)
    {

        Console.WriteLine("Hjälten vann!");

        End();

    }




    void Tank()
    {
        Random random = new Random();
        int eDamage = Random.Shared.Next(1, 9);        // tanks damage
        villanHp -= eDamage;
        Console.WriteLine($" Skurken skadades {eDamage} och har nu {villanHp} kvar!");

    }

    void Sniper()
    {

        Random random = new Random();
        int eDamage = Random.Shared.Next(20, 50);       //snipers damage
        villanHp -= eDamage;
        Console.WriteLine($" Skurken skadades {eDamage} och har nu {villanHp} kvar!");



    }





    void ElisDamage()
    {

        Random random = new Random();
        int eDamage = Random.Shared.Next(1, 15);   //shooters damagge
        villanHp -= eDamage;
        Console.WriteLine($" Skurken skadades {eDamage} och har nu {villanHp} kvar!");

    }

    void Assasin() {

        
        Random random = new Random();
        int eDamage = Random.Shared.Next(1, 5);   //assasin damage
        villanHp -= eDamage;
        Console.WriteLine($" Skurken skadades {eDamage} och har nu {villanHp} kvar!");  // han inte använda denna tyvärr


    }

    void NormalMode()
    {

        Random random = new Random();
        int tDamage = Random.Shared.Next(1, 15); // hur mycket skada enemy gör
        heroHp -= tDamage;
        Console.WriteLine($" Hjälten skadades {tDamage} och har nu {heroHp} kvar!");

    }


    void HardMode()
    {

        Random random2 = new Random();
        int hVillan = Random.Shared.Next(10, 30);      // enemty skada
        heroHp -= hVillan;
        Console.WriteLine($" Hjälten skadades {hVillan} och har nu {heroHp} kvar!");
    }


    void EasyMode()
    {

        Random random3 = new Random();
        int hVillan = Random.Shared.Next(1, 8);  // enemy skada
        heroHp -= hVillan;
        Console.WriteLine($" Hjälten skadades {hVillan} och har nu {heroHp} kvar!");
    }

    void End()
    {

        Console.WriteLine("Vill du spela igen?");
        string answer = Console.ReadLine() ?? string.Empty;
        if (answer.ToLower() == "ja")
        {

            heroHp = 100;
            villanHp = 100;      // en funktion där spelaren får välja att börja om eller inte. Om spelaren säger ja så resetas alla hp samt rounds
            round = 1;


        }
        else if (answer.ToLower() == "nej")
        {

            Console.WriteLine("Synd! Du måste!");    // om de säger nej så måste de ändå spela om

        }

    }

    void Special()
    {
  // en special funktion med en quiz runda där spelaren för ett random tal * tal
        if (round == 4)
        {

            Console.WriteLine("SPECIAL QUIZ ROUND!");
            Console.WriteLine($"Vad är {number} * {number2}?");

            string answer = Console.ReadLine() ?? string.Empty;

            if (answer == (number * number2).ToString())       // tar random int från början och gångrar med varandra och gör den till en string som läses av, om spelaren har svarat nummer * nummer så är det rätt
            {
                villanHp -= 25;
                Console.WriteLine("Rätt svar! Skurken tog 25 CRITICAL HIT!");       // om de svarar rätt så tar villan -25hp
            }
            else
            {
                heroHp -= 25;
                Console.WriteLine("Fel svar! Du tar -25 CRITICAL HIT!");  // om de svarar fel tar hero - 25hp
            }

        }


    }




}