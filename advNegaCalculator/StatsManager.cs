using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advAssistProgram
{
    class StatsManager
    {
        string[,] stats;
        int enemiesNumber = 0, personalityNumber = 0;
        string filePath;
        string[,] personality;

        public StatsManager(string Path)
        {
            filePath = @Path;
        }

        public int UpdateData()
        { 
            int i = 0, j = 0;
            if (filePath == "")
                throw new Exception("You must put something in the file path");
            StreamReader sr, numberFinder, personalityFinder;
            try
            {
                sr = new StreamReader(filePath);
                numberFinder = new StreamReader(filePath);
                personalityFinder = new StreamReader(filePath);
            }
            catch 
            { 
                return -1;
            }

            //uso numberFinder per ottenere il numero di creature di cui conosco le statistiche
            string counter = numberFinder.ReadLine();
            while(counter != null)
            {
                if (counter.Contains("Is a boss"))
                    enemiesNumber++;
                counter = numberFinder.ReadLine();
            }

            stats = new string[enemiesNumber, 6];

            //uso personalityFinder per trovare il numero di personalità differenti che il nemico può avere
            counter = personalityFinder.ReadLine();
            while (counter != null)
            {
                if (counter.Contains('"'))
                    personalityNumber++;
                counter = personalityFinder.ReadLine();
            }

            personality = new string[personalityNumber, 3];

            string line = sr.ReadLine();

            int c = 0;
            //metto in personality i valory personalità inseriti all'inizio del file stats.txt
            while (line != "")
            {
                personality[c, 0] = line.Substring(1, line.IndexOf('"', 2) - 1);

                personality[c, 1] = line.Substring(line.IndexOf("[") + 1, line.IndexOf(",") - (line.IndexOf("[") + 1));
                personality[c, 2] = line.Substring(line.IndexOf(",") + 2, line.IndexOf("]") - (line.IndexOf(",") + 1) - 1);

                c++;
                line = sr.ReadLine();
            }

            line = sr.ReadLine();

            while (line != null)
            {
                if (line.Contains(':') && !line.Contains("Is a boss") && !line.Contains('"')) //aggiungo alla matrice solo righe con contenuto utile
                {
                    stats[i, j] = line;
                    if (j < 5)
                        j++;
                    else
                    {
                        i++;
                        j = 0;
                    }
                }
                line = sr.ReadLine();
            }

            for(i = 0; i < enemiesNumber; i ++) // rimuovo le parti di testo non necessarie
            {
                //j = 0, prima riga, rimuovo tutto tranne il nome del boss
                string name = stats[i, 0];
                name = name.Remove(0, 9);
                name = name.Remove(name.IndexOf(" has "));
                stats[i, 0] = name;

                string value;

                for(j = 1; j < 6; j++)
                {
                    value = stats[i, j];
                    value = value.Substring(value.IndexOf("[") + 1, value.IndexOf("]") - value.IndexOf("[") - 1);
                    stats[i, j] = value;
                }
            }

            bool swap = true;
            while(swap)
            {
                swap = false;
                int sum1, sum2;
                int p = 0;
                while (p + 1 < enemiesNumber)
                {
                    sum1 = stats[p, 0][0];
                    sum2 = stats[p + 1, 0][0];
                    if (sum2 < sum1) // orders the stats using only the first letter
                    {
                        for (int m = 0; m < 6; m++)
                            Switch(ref stats[p, m], ref stats[p + 1, m]);
                        swap = true;
                    }
                    if(sum2 == sum1)
                    {
                        sum1 = stats[p, 1][0];
                        sum2 = stats[p + 1, 1][0];
                        if (sum2 < sum1) // orders the stats using only the second letter
                        {
                            for (int m = 0; m < 6; m++)
                                Switch(ref stats[p, m], ref stats[p + 1, m]);
                            swap = true;
                        }
                        if (sum2 == sum1)
                        {
                            sum1 = stats[p, 2][0];
                            sum2 = stats[p + 1, 2][0];
                            if (sum2 < sum1) // orders the stats using only the third letter
                            {
                                for (int m = 0; m < 6; m++)
                                    Switch(ref stats[p, m], ref stats[p + 1, m]);
                                swap = true;
                            }
                        }

                    }
                    p++;
                }
            }
            return 0;
        }

        public void Switch(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        public string getTemp(int a, int b)
        {
            return personality[a, b];
        }

        public string getName(int a)
        {
            return stats[a, 0];
        }

        public string getPersonality(int a)
        {
            return personality[a, 0];
        }

        public string getDef(int a)
        {
            return personality[a, 1];
        }

        public string getDDef(int a)
        {
            return personality[a, 2];
        }

        public int getEnemiesCount()
        {
            return enemiesNumber;
        }
        public int getPersonalityCount()
        {
            return personalityNumber;
        }

        public string getCreatureName(int i)
        {
            return stats[i, 0];
        }

        public string getHP(int i)
        {
            return stats[i, 1];
        }

        public string getDiplomacy(int i)
        {
            return stats[i, 2];
        }

        public string getPhysicalDefence(int i)
        {
            return stats[i, 3];
        }

        public string getMagicalDefence(int i)
        {
            return stats[i, 4];
        }

        public string getPersuasionDefence(int i)
        {
            return stats[i, 5];
        }
    }
}

/*how stats are saved in the array
 *      0               1               2           ...
 * 0    Mini Pekka      Goblin Giant    Knight      ...
 * 1    750.0           950.0           450.0       ...
 * 2    945.0           1200.0          300.0       ...
 * 3    1.5             1.1             1.6         ...
 * 4    0.9             1.1             0.8         ...
 * 5    1.0             1.0             1.0         ...
 */


/*All custom bosses stats
Monster: Mini Pekka has been added to the 69 theme
HP:                  [750.0]
Diplomacy:           [945.0]
Physical defence:    [1.5]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Goblin Giant has been added to the 69 theme
HP:                  [950.0]
Diplomacy:           [1200.0]
Physical defence:    [1.1]
Magical defence:     [1.1]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Knight has been added to the 69 theme
HP:                  [450.0]
Diplomacy:           [300.0]
Physical defence:    [1.6]
Magical defence:     [0.8]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Archers has been added to the 69 theme
HP:                  [373.0]
Diplomacy:           [399.0]
Physical defence:    [1.0]
Magical defence:     [1.2]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: P.E.K.K.A. has been added to the 69 theme
HP:                  [1350.0]
Diplomacy:           [1700.0]
Physical defence:    [2.0]
Magical defence:     [0.6]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Goblins has been added to the 69 theme
HP:                  [250.0]
Diplomacy:           [350.0]
Physical defence:    [0.8]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Giant has been added to the 69 theme
HP:                  [750.0]
Diplomacy:           [800.0]
Physical defence:    [1.2]
Magical defence:     [0.8]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Minions has been added to the 69 theme
HP:                  [373.0]
Diplomacy:           [423.0]
Physical defence:    [2.0]
Magical defence:     [0.8]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Balloon has been added to the 69 theme
HP:                  [800.0]
Diplomacy:           [1500.0]
Physical defence:    [1.4]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Witch has been added to the 69 theme
HP:                  [942.0]
Diplomacy:           [987.0]
Physical defence:    [1.2]
Magical defence:     [1.2]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Valkyrie has been added to the 69 theme
HP:                  [550.0]
Diplomacy:           [400.0]
Physical defence:    [1.2]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Skeleton Army has been added to the 69 theme
HP:                  [350.0]
Diplomacy:           [450.0]
Physical defence:    [4.0]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Barbarians has been added to the 69 theme
HP:                  [475.0]
Diplomacy:           [630.0]
Physical defence:    [1.2]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Golem has been added to the 69 theme
HP:                  [2400.0]
Diplomacy:           [3000.0]
Physical defence:    [0.7]
Magical defence:     [1.7]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Skeletons has been added to the 69 theme
HP:                  [100.0]
Diplomacy:           [130.0]
Physical defence:    [1.3]
Magical defence:     [0.7]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Bomber has been added to the 69 theme
HP:                  [240.0]
Diplomacy:           [300.0]
Physical defence:    [1.0]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Musketeer has been added to the 69 theme
HP:                  [350.0]
Diplomacy:           [300.0]
Physical defence:    [0.9]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Baby Dragon has been added to the 69 theme
HP:                  [500.0]
Diplomacy:           [475.0]
Physical defence:    [1.3]
Magical defence:     [1.4]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Prince has been added to the 69 theme
HP:                  [550.0]
Diplomacy:           [475.0]
Physical defence:    [1.4]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Wizard has been added to the 69 theme
HP:                  [400.0]
Diplomacy:           [600.0]
Physical defence:    [0.8]
Magical defence:     [1.3]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Spear Goblins has been added to the 69 theme
HP:                  [200.0]
Diplomacy:           [500.0]
Physical defence:    [1.0]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Giant Skeleton has been added to the 69 theme
HP:                  [750.0]
Diplomacy:           [900.0]
Physical defence:    [1.7]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Hog Rider has been added to the 69 theme
HP:                  [440.0]
Diplomacy:           [515.0]
Physical defence:    [0.8]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Minion Horde has been added to the 69 theme
HP:                  [555.0]
Diplomacy:           [623.0]
Physical defence:    [1.8]
Magical defence:     [0.7]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Ice Wizard has been added to the 69 theme
HP:                  [313.0]
Diplomacy:           [420.0]
Physical defence:    [1.5]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Royal Giant has been added to the 69 theme
HP:                  [740.0]
Diplomacy:           [670.0]
Physical defence:    [1.1]
Magical defence:     [1.3]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Guards has been added to the 69 theme
HP:                  [333.0]
Diplomacy:           [500.0]
Physical defence:    [1.3]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Princess has been added to the 69 theme
HP:                  [400.0]
Diplomacy:           [350.0]
Physical defence:    [0.9]
Magical defence:     [1.2]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Dark Prince has been added to the 69 theme
HP:                  [525.0]
Diplomacy:           [647.0]
Physical defence:    [1.5]
Magical defence:     [1.5]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Three Musketeers has been added to the 69 theme
HP:                  [1750.0]
Diplomacy:           [1500.0]
Physical defence:    [1.0]
Magical defence:     [0.8]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Lava Hound has been added to the 69 theme
HP:                  [1400.0]
Diplomacy:           [1350.0]
Physical defence:    [4.0]
Magical defence:     [0.8]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: D83 Dragon has been added to the 69 theme
HP:                  [3333.0]
Diplomacy:           [3333.0]
Physical defence:    [1.33]
Magical defence:     [1.33]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Justin has been added to the 69 theme
HP:                  [1000.0]
Diplomacy:           [300.0]
Physical defence:    [1.0]
Magical defence:     [0.5]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Ice Spirit has been added to the 69 theme
HP:                  [250.0]
Diplomacy:           [300.0]
Physical defence:    [1.3]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Fire Spirits has been added to the 69 theme
HP:                  [372.0]
Diplomacy:           [534.0]
Physical defence:    [1.3]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Miner has been added to the 69 theme
HP:                  [673.0]
Diplomacy:           [472.0]
Physical defence:    [1.0]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Sparky has been added to the 69 theme
HP:                  [1773.0]
Diplomacy:           [2465.0]
Physical defence:    [1.2]
Magical defence:     [1.1]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Bowler has been added to the 69 theme
HP:                  [600.0]
Diplomacy:           [895.0]
Physical defence:    [1.2]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Lumberjack has been added to the 69 theme
HP:                  [500.0]
Diplomacy:           [1100.0]
Physical defence:    [1.8]
Magical defence:     [2.1]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Battle Ram has been added to the 69 theme
HP:                  [1150.0]
Diplomacy:           [1200.0]
Physical defence:    [0.6]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Inferno Dragon has been added to the 69 theme
HP:                  [2350.0]
Diplomacy:           [3721.0]
Physical defence:    [1.9]
Magical defence:     [0.8]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Ice Golem has been added to the 69 theme
HP:                  [350.0]
Diplomacy:           [500.0]
Physical defence:    [0.8]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Mega Minion has been added to the 69 theme
HP:                  [424.0]
Diplomacy:           [424.0]
Physical defence:    [1.5]
Magical defence:     [0.8]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Dart Goblin has been added to the 69 theme
HP:                  [273.0]
Diplomacy:           [325.0]
Physical defence:    [0.8]
Magical defence:     [0.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Goblin Gang has been added to the 69 theme
HP:                  [1150.0]
Diplomacy:           [1750.0]
Physical defence:    [1.4]
Magical defence:     [0.6]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Electro Wizard has been added to the 69 theme
HP:                  [732.0]
Diplomacy:           [976.0]
Physical defence:    [1.2]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Elite Barbarians has been added to the 69 theme
HP:                  [5225.0]
Diplomacy:           [4267.0]
Physical defence:    [0.5]
Magical defence:     [0.7]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Hunter has been added to the 69 theme
HP:                  [673.0]
Diplomacy:           [772.0]
Physical defence:    [1.0]
Magical defence:     [1.0]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Executioner has been added to the 69 theme
HP:                  [1150.0]
Diplomacy:           [1300.0]
Physical defence:    [0.7]
Magical defence:     [1.9]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Bandit has been added to the 69 theme
HP:                  [575.0]
Diplomacy:           [723.0]
Physical defence:    [0.7]
Magical defence:     [1.2]
Persuasion defence:  [1.0]
Is a boss:           [False]

Monster: Royal Recruits has been added to the 69 theme
HP:                  [3333.0]
Diplomacy:           [6666.0]
Physical defence:    [1.7]
Magical defence:     [0.7]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Night Witch has been added to the 69 theme
HP:                  [724.0]
Diplomacy:           [867.0]
Physical defence:    [1.2]
Magical defence:     [1.2]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Mark - Dragons Eight Leader has been added to the 69 theme
HP:                  [2750.0]
Diplomacy:           [4200.0]
Physical defence:    [0.7]
Magical defence:     [0.7]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Zekrom has been added to the 69 theme
HP:                  [1750.0]
Diplomacy:           [1296.0]
Physical defence:    [1.85]
Magical defence:     [1.9]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Yuuki has been added in the 69 theme
HP:                  [2500.0]
Diplomacy:           [3000.0]
Physical defence:    [1.3]
Magical defence:     [0.8]
Persuasion defence:  [0.9]
Is a boss:           [True]

Monster: Sai has been added to the 69 theme
HP:                  [1975.0]
Diplomacy:           [3500.0]
Physical defence:    [0.8]
Magical defence:     [1.4]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Dialga has been added to the 69 theme
HP:                  [2496.0]
Diplomacy:           [3107.0]
Physical defence:    [1.2]
Magical defence:     [1.7]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Prince Vegita has been added to the 69 theme
HP:                  [5000.0]
Diplomacy:           [2512.0]
Physical defence:    [2.0]
Magical defence:     [2.0]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Sad Cloud has been added to the 69 theme
HP:                  [5000.0]
Diplomacy:           [1600.0]
Physical defence:    [1.7]
Magical defence:     [2.2]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Uchiha Madara has been added to the 69 theme
HP:                  [1732.0]
Diplomacy:           [3798.0]
Physical defence:    [0.65]
Magical defence:     [0.5]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Joker has been added to the 69 theme
HP:                  [1394.0]
Diplomacy:           [4000.0]
Physical defence:    [0.7]
Magical defence:     [0.5]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Ryuga - Dragon emperor has been added to the 69 theme
HP:                  [5069.0]
Diplomacy:           [1669.0]
Physical defence:    [0.69]
Magical defence:     [0.69]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Kaido has been added to the 69 theme
HP:                  [4200.0]
Diplomacy:           [2700.0]
Physical defence:    [1.2]
Magical defence:     [0.8]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Arjuna has been added to the 69 theme
HP:                  [2500.0]
Diplomacy:           [2900.0]
Physical defence:    [0.7]
Magical defence:     [1.3]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Lancer of Red has been added to the 69 theme
HP:                  [3200.0]
Diplomacy:           [1632.0]
Physical defence:    [0.4]
Magical defence:     [0.7]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Ren Amamiya(Joker) has been added to the 69 theme
HP:                  [2398.0]
Diplomacy:           [3178.0]
Physical defence:    [0.5]
Magical defence:     [1.7]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Beru has been added to the 69 theme
HP:                  [1800.0]
Diplomacy:           [2100.0]
Physical defence:    [1.3]
Magical defence:     [2.4]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Marco has been added to the 69 theme
HP:                  [2600.0]
Diplomacy:           [2200.0]
Physical defence:    [1.9]
Magical defence:     [0.6]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Akuma has been added to the 69 theme
HP:                  [1800.0]
Diplomacy:           [1200.0]
Physical defence:    [1.6]
Magical defence:     [0.8]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Luffy has been added to the 69 theme
HP:                  [3900.0]
Diplomacy:           [2800.0]
Physical defence:    [2.8]
Magical defence:     [1.8]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Rui has been added to the 69 theme
HP:                  [2700.0]
Diplomacy:           [2200.0]
Physical defence:    [0.8]
Magical defence:     [1.6]
Persuasion defence:  [1.0]
Is a boss:           [True]

Monster: Okok has been added to the 69 theme
HP:                  [1669.0]
Diplomacy:           [4069.0]
Physical defence:    [0.5]
Magical defence:     [6.9]
Persuasion defence:  [1.0]
Is a boss:           [True]
*/