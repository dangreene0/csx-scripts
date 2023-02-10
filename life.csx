// CTRL + SHIFT + B to start the app
class Life {
    string watermark = 
    @"MMMMMMMMMMMMKd:oKXXXXXXXXXXXXXXXXK0ddXMMMMMMMMMMMM
MMMMMMMMMMMMW0l:o0XXXXXXXXXXXXXXK0do0WMMMMMMMMMMMM
MMMMMMMMMMMMMWKd::d0XXXXXXXXXXKOdoxKWMMMMMMMMMMMMM
MMMMMMMMMMMMMMMN0d:coxKXXXXK0kdox0NMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWKkl:lxO0OdodkKWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMN0dlcccc:lkNWMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWX0xodk000Oxl:cd0WMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMWXOddxOXNNNNNXKOxl:o0WMMMMMMMMMMMMMM
MMMMMMMMMMMMMW0dox0XXXXXXXXXXXX0dc:xNMMMMMMMMMMMMM
MMMMMMMMMMMMWKdoOXXKXXXXXXXKXXXKKkl:xWMMMMMMMMMMMM
MMMMMMMMMMMMWKoo0XXXXXXXXXXXXXXXX0d:dWMMMMMMMMMMMM
MMMMMMMMMMMMMXkod0XXXXXXXXXXXXXX0xcc0MMMMMMMMMMMMM
MMMMMMMMMMMMMWNOdok0XXXXXXXXXK0kl:oKWMMMMMMMMMMMMM
MMMMMMMMMMMMMMMWXOdoodOKXXKOdc:cd0WMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWNKkoldddl:coOXWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWN0dccoxxdllx0NWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMWKkl:coOKXXX0kdookKWMMMMMMMMMMMMMMM
MMMMMMMMMMMMMWXxccdOXXXXXXXXXXKOdoxXWMMMMMMMMMMMMM
MMMMMMMMMMMMWKo:lOXXXXNNNXNNXNNXKOdoKWMMMMMMMMMMMM
MMMMMMMMMMMMXd:lKXXXXXXXXXXXXXXXXKOddXMMMMMMMMMMMM";
    string loser = 
    @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMN0kdoooodk0NMMMMMMMMMMMMMM
MMMMMMMMMMMWKo,.        .,oKWMMMMMMMMMMM
MMMMMMMMMMNx'              'xNMMMMMMMMMM
MMMMMMMMMMx.                .xWMMMMMMMMM
MMMMMMMMMNc                  cNMMMMMMMMM
MMMMMMMMMNl   ....    ....   lNMMMMMMMMM
MMMMMMMMMMk..cOKKk,  ,kKKOc..kMMMMMMMMMM
MMMMMMMMMM0''OWWXx'  'xXWWO''0MMMMMMMMMM
MMMMMMMMMMK:.';;'.:xx:.';;'.:KMMMMMMMMMM
MMMMMKo:dXMNOl.  .oOOo.  .lONMW0odKMMMMM
MMMMNo. .:OXWWo.        .oWMWXd' .oWMMMM
MMMWd.  . .':oxxdolllloxkOxl:..   .dWMMM
MMMMKdoxkdc;...':ok00Odc,...';coo::kWMMM
MMMMMMMMMMMWKxc.  ....  .cx0XWMMMWWMMMMM
MMMMXxx0KOdl:'...;looc,...;ldOKNN0KWMMMM
MMMNl. ... .':okKWMMMMN0xl,. ..,'..dWMMM
MMMMK:. .;d0XWMMMMMMMMMMMMN0xl'. .:0MMMM
MMMMWO;,dNMMMMMMMMMMMMMMMMMMMM0;.,OMMMMM
MMMMMMWNWMMMMMMMMMMMMMMMMMMMMMMNKXWMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM";
    string winner = 
    @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMNKkdlcdKNNNNNNNWWMMMMMMMMMMM
MMMMMMMMMN0d:ol':lkNWWOl:cdxk0NMMMMMMMMM
MMMMMMMXd:,.,OXXWWNkll'      .,dXMMMMMMM
MMMMMNx. .,:xXMMMMXl'......     'xWMMMMM
MMMMNl  ,xKWMMMMMWx.  .';,..     .oNMMMM
MMMWx:,;OWMMMMMWNd.            .. .dWMMM
MMMKooxookXMMMMWXc           .,OXo.cNMMM
MMMNKOc...:kNMMMMXxllo:.     .kWMNOONMMM
MMMNNX:    .'oXMMMMMMMNl    .OWWMMMNNMMM
MMMNNW0c.    cWMMMMMMMMx.   ;oOWMMMNNMMM
MMMWNWMNc   :KMMMMMMMMMO.  c0kKWMMNNWMMM
MMMMNXWMO..lXMMMMMMMMMMWkcxNMMMMMWXNMMMM
MMMMMNXNWkcOWMMMMMMMMMMMMMMMMMMNKKNMMMMM
MMMMMMWKOOOKNNWMMMMMMMMMMMNX0kooONMMMMMM
MMMMMMMWXkol;;kWMMN0OOkxoc,.,cxXMMMMMMMM
MMMMMMMMMMWKxooddl;'....,:okXWMMMMMMMMMM
MMMMMMMMMMMMMMWNXKK000KXWMMMMMMMMMMMMMMM
WWWWWWWWWWWNNNWNNNNNNNNNNWNNWNWWWWWWWWWW";
    string civName, godName, civLocation;
    int heat, vegetation, population, level;
    Dictionary<string, int[]> climates = new Dictionary<string, int[]>(){
        // numbers are in order of the above integers
        {"Rocky", new int[] {6, 4, 6}},
        {"Coastal", new int[] {7, 8, 9}},
        {"Mountainous", new int[] {1, 8, 4}},
        {"Desert", new int[] {10, 2, 2}},
        {"Forested", new int[] {4, 10, 2}},
        {"Plains", new int[] {1, 8, 9}}
    };
    // could make this a dictionary where the name is the key and a array of stats is the value
    public void main(){
        Console.Clear();
        Console.WriteLine(watermark);
        intro();
        location();
        chooseStat();
        seasons();
    }

    void intro(){
        Console.WriteLine("Welcome to the evolution simulator!");
        Console.WriteLine("What is the name of your civilization?");
        civName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"What is the name of you, {civName}'s almighty god.");
        godName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"{civName} is the jewel of {godName}.");
    }

    void location(){
        string locationPreParse = "";
        int locationNum = 0, errors = 0, i = 0;

        Console.WriteLine("Where does your civilization live?");
        
        foreach(string c in climates.Keys) {
            i++;
            Console.WriteLine($"{i}. {c} Climate.");
        }
        Console.WriteLine("Please select a number.");
        
        while (locationNum == 0) {
            if (errors > 4){
                Console.WriteLine("Too much trollage, ending simulation.");
                exit();
            }
            locationPreParse = Console.ReadLine();
            if (int.TryParse(locationPreParse, out locationNum)){
                if (locationNum > climates.Count || locationNum < 1){
                    Console.WriteLine("Selection is not available. Please select another.");
                    locationNum = 0;
                    errors++;
                    continue;
                }
                int selection = --locationNum;
                Console.Clear();
                Console.WriteLine($"You selected the {climates.ElementAt(selection).Key} climate.");
                civLocation = climates.ElementAt(selection).Key;
                break;
            }
            else{
                Console.WriteLine("That is not a number");
                errors++;
            }
        }
        stats(civLocation);
    }
    void stats(string selection){
        heat = climates[selection][0];
        vegetation = climates[selection][1];
        population = climates[selection][2];
    }
    
    void seasons(){
        while (population != 0){
            string levelNotes = "", deathReason = "";
            int previousLevel = level, previousHeat = heat, previousVeg = vegetation, previousPop = population;

            if (population < 3 ) {levelNotes += "Your population is getting dangerously low, please advise.\n"; }
            if (heat > 14){heat = 14; levelNotes += "Never has man known a worse fate then the fires of summer.\n";}
            if (heat > 11){ population--; vegetation++; levelNotes += "The heat has taken the lives of some of your people, but allowed for the plants to grow.\n";}
            if (heat == 10 ) {levelNotes += "Your civilizations temperatures are dangerously high.\n";}
            if (vegetation < population && population > 6) { vegetation--; levelNotes += "Your people are overeating. Lost vegetation.\n";}
            if (vegetation < 4) {heat++; levelNotes += "Your land is low on vegetation, your civilization will suffer.\n"; }
            if (vegetation > heat && population < 6 && vegetation < 5){heat--; levelNotes +="The plants were able to cool off your civilization.\n";}
            if (population < 5 && vegetation < 6){heat--; levelNotes +="The low population cooled off under the trees.\n";}

            if (vegetation < 0){ vegetation = 0; levelNotes += "The foolish god has no morsels to spare. The civilization can sustain no life.\n";}
            if (heat < 3){vegetation--; levelNotes +="Frost begins to form upon the plants, it is a cruel Winter.\n";}
            if (heat < 0){ heat = 0;}

            ++level;   
            if (level > previousLevel){Console.WriteLine($"Welcome to level {level}");};
            if (population < 1 ){
                deathReason += "Population depleted.\n"; 
                if (heat < 10) {
                    deathReason += "Their charred remains smolder under the sun.\n";
                }
                if (vegetation < 2) {
                    deathReason += "Unsustainable vegetation destroyed the food supply.\n";
                }
                gameOver(deathReason);
            }
            if (levelNotes == ""){levelNotes += "There is peace, but for how long...";}
            Console.WriteLine(levelNotes);
            Console.WriteLine("Stats");
            Console.WriteLine($"Heat: {previousHeat} --> {heat}");
            Console.WriteLine($"Vegetation: {previousVeg} --> {vegetation}");
            Console.WriteLine($"Population: {previousPop} --> {population}");
            Console.ReadLine();
            Console.Clear();
            if (level == 20){victory();}
            chooseStat();
        }
        
    }

    void chooseStat(){
        int selection = 0;
        string choice = "";
        Console.WriteLine(
            "You may choose one area to add a stat point to:"
        );
        Console.WriteLine($"1. Heat - {heat}");
        Console.WriteLine($"2. Vegetation - {vegetation}");
        Console.WriteLine($"3. Population - {population}");

        while (selection == 0) {
            string selectionPreParse = Console.ReadLine();
            if (int.TryParse(selectionPreParse, out selection)){
                if (selection > 3 || selection < 0){
                    selection = 0;
                    Console.WriteLine("Selection is not available. Please select another.");
                    continue;
                }
            }
        }
        int previousValue = 0, newValue = 0;
        switch(selection){
            case 1:
                choice = "Heat";
                previousValue = heat;
                heat++;
                newValue = heat;
                break;
            case 2:
                choice = "Vegetation";
                previousValue = vegetation;
                vegetation++;
                newValue = vegetation;
                break;
            case 3:
                choice = "Population";
                previousValue = population;
                population++;
                newValue = population;
                break;
        }
        Console.WriteLine($"You chose to add 1 point to {choice}.");
        Console.WriteLine($"{choice}: {previousValue} --> {newValue}");
        Console.ReadLine();
    }

    void gameOver(string deathReason){
        Console.Clear();
        Console.WriteLine(loser);
        Console.WriteLine(deathReason);
        Console.WriteLine($"{civName} has suffered a terrible fate.");
        Console.WriteLine($"We hoped {godName} would have been more merciful.");
        Console.WriteLine(".... I can still hear their screams.");
        Console.ReadLine();
        exit();
    }

    void victory(){
        Console.Clear();
        Console.WriteLine(winner);
        Console.WriteLine($"Congratulations! {civName} has survived defeat!");
        Console.WriteLine($"${godName} is a wise god and your people thank you for being merciful.");
        Console.ReadLine();
        exit();
    }
    void exit(){
        Console.Clear();
        Console.WriteLine($"Thanks for playing, {godName}.");
        Console.WriteLine($"{civName} was a beautiful civilization.");
        Environment.Exit(0);
    }
}
Life life = new Life();
life.main();