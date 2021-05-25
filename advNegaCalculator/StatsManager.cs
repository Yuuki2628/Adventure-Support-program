using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace advAssistProgram
{
    class StatsManager
    {
        string[,] stats;
        int enemiesNumber = 206, personalityNumber = 35;
        string filePath;
        string[,] personality;

        public StatsManager(string Path)
        {
            filePath = @Path;
        }

        public void UpdateData()
        {
            bool swap = true;
            while (swap) //it's ordering all the enemies names alphabetically
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
                    if (sum2 == sum1)
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

            swap = true;
            while (swap) // it's ordering all the personalities's names alphabetically
            {
                swap = false;
                int sum1, sum2;
                int p = 0;
                while (p + 1 < personalityNumber)
                {
                    sum1 = personality[p, 0][0];
                    sum2 = personality[p + 1, 0][0];
                    if (sum2 < sum1) // orders the stats using only the first letter
                    {
                        for (int m = 0; m < 3; m++)
                            Switch(ref personality[p, m], ref personality[p + 1, m]);
                        swap = true;
                    }
                    if (sum2 == sum1)
                    {
                        sum1 = personality[p, 1][0];
                        sum2 = personality[p + 1, 1][0];
                        if (sum2 < sum1) // orders the stats using only the second letter
                        {
                            for (int m = 0; m < 3; m++)
                                Switch(ref personality[p, m], ref personality[p + 1, m]);
                            swap = true;
                        }
                        if (sum2 == sum1)
                        {
                            sum1 = personality[p, 2][0];
                            sum2 = personality[p + 1, 2][0];
                            if (sum2 < sum1) // orders the stats using only the third letter
                            {
                                for (int m = 0; m < 3; m++)
                                    Switch(ref personality[p, m], ref personality[p + 1, m]);
                                swap = true;
                            }
                        }

                    }
                    p++;
                }
            }
        }

        public void Switch(ref string a, ref string b) //switches 2 variable's content
        {
            string temp = a;
            a = b;
            b = temp;
        }

        /*public string getTemp(int a, int b)
        {
            return personality[a, b];
        }*/

        public string getName(int a) //return an enemy's name
        {
            return stats[a, 0];
        }

        public string getPersonality(int a) //returns an enemy's personality
        {
            return personality[a, 0];
        }

        public string getDef(int a) //returns an enemy's hp defense
        {
            return personality[a, 1];
        }

        public string getDDef(int a) //returns an enemy's diplomacy defence
        {
            return personality[a, 2];
        }

        public int getEnemiesCount() //returns how many enemies are there
        {
            return enemiesNumber;
        }
        public int getPersonalityCount() //return how many personalities are there
        {
            return personalityNumber;
        }

        public string getCreatureName(int i) //return an enemy's name
        {
            return stats[i, 0];
        }

        public string getHP(int i) //return an enemy's health
        {
            return stats[i, 1];
        }

        public string getDiplomacy(int i) //return an enemy's diplomacy
        {
            return stats[i, 2];
        }

        public string getPhysicalDefence(int i) //return an enemy's physical defenee
        {
            return stats[i, 3];
        }

        public string getMagicalDefence(int i) //return an enemy's magical defense
        {
            return stats[i, 4];
        }

        public string getPersuasionDefence(int i) //return an enemy's persuasion defence
        {
            return stats[i, 5];
        }

        public StatsManager()
        {
            stats = new string[,]
            {
                {"Tame Dove","546.5","530.5","1.2","1.2","1.0"},
                {"Weasel","512.75","538.75","1.2","1.2","1.0"},
                {"Bat","543.0","511.5","1.01","1.55","1.0"},
                {"Snake","507.0","522.25","1.7","1.43","1.0"},
                {"Red Squirrel","519.25","544.75","1.2","1.67","1.0"},
                {"Mouse","513.25","504.5","1.6","1.31","1.0"},
                {"Rat","525.5","526.5","1.77","2.03","1.0"},
                {"Wild Dove","537.5","550.5","1.2","1.2","1.0"},
                {"Seagull","513.75","532.0","1.4","1.74","1.0"},
                {"Orc Peon","525.5","506.25","28.92","1.21","1.0"},
                {"Imp","544.0","515.0","1.2","1.08","1.0"},
                {"Petty Thief","515.0","521.0","1.2","1.2","1.0"},
                {"Gnoll","547.0","508.5","1.51","1.2","1.0"},
                {"Slime","524.0","517.0","1.4","1.2","1.0"},
                {"Kobold","524.75","543.5","1.2","1.2","1.0"},
                {"Bandit","501.75","541.75","1.2","1.3","1.0"},
                {"Cave Rat","532.75","515.5","1.2","1.51","1.0"},
                {"Plagued Deer","513.75","523.5","1.04","1.33","1.0"},
                {"Orc","549.0","503.5","1.83","1.2","1.0"},
                {"Raven","504.0","549.5","1.13","29.47","1.0"},
                {"Eagle","516.5","545.0","1.2","1.2","1.0"},
                {"Sylph","533.5","512.0","1.4","1.2","1.0"},
                {"Barred Owl","516.75","540.0","1.43","2.9","1.0"},
                {"Goose","533.75","530.0","1.2","1.5","1.0"},
                {"Frost Spider","513.0","521.0","1.88","1.2","1.0"},
                {"Siren","539.5","513.0","1.2","1.49","1.0"},
                {"Rotting Slime","540.5","545.25","2.1","1.2","1.0"},
                {"Brown Eagle","509.0","545.0","1.2","1.6","1.0"},
                {"Forest Sprite","539.0","543.0","1.42","1.1","1.0"},
                {"Lone Wolf","507.0","513.25","1.94","1.2","1.0"},
                {"Assassin","546.25","518.5","2.32","1.9","1.0"},
                {"Giant Eagle","507.25","513.0","1.1","1.2","1.0"},
                {"Ram","539.0","533.0","1.2","1.27","1.0"},
                {"Forest Fairie","505.0","518.5","1.74","1.2","1.0"},
                {"Troll Slave","501.0","526.5","1.2","2.03","1.0"},
                {"Striped Kestrel","528.0","514.5","1.2","1.97","1.0"},
                {"Goblin","524.25","544.5","1.2","1.73","1.0"},
                {"Bloodtooth Wolf","532.5","500.5","2.08","1.2","1.0"},
                {"Rabbit Spirit","502.5","506.5","1.2","2.1","1.0"},
                {"Tiger","505.5","517.0","1.2","1.85","1.0"},
                {"Wild Stallion","509.5","511.5","1.9","1.2","1.0"},
                {"Ogre","510.5","531.5","2.05","1.49","1.0"},
                {"Orc Slavedriver","544.5","518.25","1.2","1.2","1.0"},
                {"Ogre Bruiser","515.5","508.75","1.69","1.2","1.0"},
                {"Flatland Cougar","536.0","539.25","1.7","1.5","1.0"},
                {"Forest Guardian","540.0","523.25","1.2","1.2","1.0"},
                {"Swan","531.0","530.75","1.2","1.2","1.0"},
                {"Dryad Spellcaster","517.25","543.25","1.48","1.22","1.0"},
                {"Voidwalker Demon","545.25","522.5","1.05","1.24","1.0"},
                {"Harpy Witch","519.25","527.5","1.97","1.2","1.0"},
                {"Skeleton Troop Leader","528.0","531.75","1.75","1.69","1.0"},
                {"Troll Guard","551.0","515.0","2.08","1.2","1.0"},
                {"Wood Spider","536.25","534.5","4.5","1.49","1.0"},
                {"Centaur Spirit-talker","541.5","521.75","1.33","1.4","1.0"},
                {"Trickster Faun","530.5","509.25","1.5","1.42","1.0"},
                {"Dappled Centaur","508.5","523.5","1.55","1.98","1.0"},
                {"Skeleton Berserker","520.0","546.0","1.78","1.81","1.0"},
                {"Possessed Sword","508.5","533.5","1.2","1.2","1.0"},
                {"Mountain Troll","530.75","523.0","1.2","1.73","1.0"},
                {"Fire Hawk","530.25","541.5","1.11","1.84","1.0"},
                {"Arcane Construct","532.75","513.5","1.7","2.46","1.0"},
                {"Troll Berserker","509.75","523.5","1.2","2.08","1.0"},
                {"Spectral Spirit","501.0","505.25","1.2","1.2","1.0"},
                {"Fox Spirit","501.0","542.0","1.4","1.75","1.0"},
                {"Balrog","540.0","531.0","1.81","1.2","1.0"},
                {"Doomsayer Cultist","514.25","513.25","1.69","1.49","1.0"},
                {"Centaur Archwizard","524.0","548.75","1.05","1.2","1.0"},
                {"Deer Spirit","506.25","548.0","1.79","1.73","1.0"},
                {"Succubus","513.5","537.25","1.44","1.9","1.0"},
                {"Bear","546.5","546.0","1.2","1.63","1.0"},
                {"Satyr Bard","533.5","527.25","1.1","1.2","1.0"},
                {"Possessed Tome","534.0","528.5","1.85","1.3","1.0"},
                {"Owlspider","507.5","510.0","1.64","1.2","1.0"},
                {"Reanimated Skeleton","523.75","533.75","1.31","1.2","1.0"},
                {"Satyr Spellcaster","549.25","549.5","1.21","2.9","1.0"},
                {"Satyr","525.25","539.75","1.23","1.2","1.0"},
                {"Rabid Boar","508.25","539.5","2.9","1.47","1.0"},
                {"Fire Spirit","516.25","508.5","1.72","1.2","1.0"},
                {"Giant Roc","506.0","509.0","1.67","1.2","1.0"},
                {"Forest Atronach","515.5","542.5","1.51","1.59","1.0"},
                {"Jaguar","514.5","537.25","1.2","1.9","1.0"},
                {"Sabre Cat","512.5","510.5","1.78","1.71","1.0"},
                {"Bog Beast","530.75","501.75","1.86","2.0","1.0"},
                {"Elder Treant","506.5","549.0","1.87","1.99","1.0"},
                {"Wormwing Demon","522.0","504.0","1.2","1.2","1.0"},
                {"Cultist Lord","528.25","507.75","1.2","1.9","1.0"},
                {"Cave Lion","527.25","508.5","1.15","1.18","1.0"},
                {"Arcane-Touched Satyr","523.25","514.5","1.97","2.11","1.0"},
                {"Aether Wolf","550.5","526.5","1.2","1.48","1.0"},
                {"Abyssal Demon","507.75","523.0","1.2","1.2","1.0"},
                {"Rabid Cave Bear","550.75","539.0","1.26","1.2","1.0"},
                {"Harpy Windsinger","513.75","530.0","1.35","1.29","1.0"},
                {"Treant","542.0","518.0","1.95","1.9","1.0"},
                {"Restless Ghost","517.5","522.0","1.2","1.94","1.0"},
                {"Tree Spirit","546.5","547.0","1.7","1.2","1.0"},
                {"Aether Faerie","511.5","519.0","1.65","2.71","1.0"},
                {"Sylvan Unicorn","539.0","533.25","1.2","1.58","1.0"},
                {"Bronze Guardian","503.0","503.0","1.9","1.66","1.0"},
                {"Spriggan","511.0","503.5","1.2","1.04","1.0"},
                {"Celestial Unicorn","533.5","545.25","1.5","1.2","1.0"},
                {"Voidspawn Demon","542.5","500.5","1.55","1.9","1.0"},
                {"Harpy Matriarch","509.5","551.0","1.2","1.75","1.0"},
                {"Orc Shieldbreaker","509.5","516.0","1.21","1.9","1.0"},
                {"Arcane-Touched Spriggan","511.75","510.0","1.2","1.55","1.0"},
                {"Trickster Tree Spirit","546.25","536.0","1.2","1.2","1.0"},
                {"Spectral Kingfisher","531.75","529.0","1.2","2.21","1.0"},
                {"Fire Salamander","501.75","524.0","2.29","1.2","1.0"},
                {"Troll Captain","507.75","534.0","1.2","1.26","1.0"},
                {"Corrupted Phoenix","521.0","567.5","1.2","1.99","1.0"},
                {"Fel-Corrupted Satyr","518.0","535.25","1.56","1.86","1.0"},
                {"Forest Kirin","539.25","509.25","1.2","2.16","1.0"},
                {"Incubus","539.25","507.75","1.2","1.1","1.0"},
                {"Fire Fairy","545.25","527.5","1.2","2.2","1.0"},
                {"Forest Spirit","509.0","517.0","1.53","2.21","1.0"},
                {"Skeleton Trooper","501.0","531.0","2.06","1.2","1.0"},
                {"Magma Giant","550.5","542.75","1.2","1.86","1.0"},
                {"Elder Forest Spirit","509.5","521.5","2.16","1.2","1.0"},
                {"Carved Totem","522.5","503.25","1.63","1.5","1.0"},
                {"Faerie","522.0","537.5","1.71","2.09","1.0"},
                {"Corrupted Dryad","502.5","541.5","1.2","1.49","1.0"},
                {"Lesser Felguard","529.75","547.75","1.29","2.17","1.0"},
                {"Frost Troll","509.0","524.0","1.2","1.2","1.0"},
                {"Guardian Statue","529.0","548.0","1.99","1.46","1.0"},
                {"Corrupted Unicorn","547.25","515.0","1.2","1.2","1.0"},
                {"Reanimated Totemic Guardian","506.0","508.75","1.5","1.46","1.0"},
                {"Forest Troll","531.25","504.0","1.8","1.72","1.0"},
                {"Restless Spirit","538.5","510.25","1.2","1.2","1.0"},
                {"Satyr Lord","540.5","519.0","2.45","1.08","1.0"},
                {"Charmed Wyrm Statue","544.5","601.5","1.32","1.2","1.0"},
                {"Horse Spirit","528.75","603.25","1.35","1.89","1.0"},
                {"Peacock Spirit","543.75","561.5","1.1","1.2","1.0"},
                {"Pack of Wolves","550.0","621.5","1.98","1.2","1.0"},
                {"Fog Beast","512.0","585.0","1.2","1.42","1.0"},
                {"Fog Beast Minion","505.0","527.0","1.2","1.2","1.0"},
                {"Ancient Tree Spirit","512.25","573.25","1.78","1.2","1.0"},
                {"Reanimated Statue","564.0","627.0","1.2","1.54","1.0"},
                {"Skull Spirit","526.0","539.0","1.9","1.2","1.0"},
                {"Centaur Mage","566.25","640.0","1.75","1.2","1.0"},
                {"Vapor Spirit","534.5","544.0","1.2","1.35","1.0"},
                {"Totem Spirit","522.5","515.5","1.2","1.2","1.0"},
                {"Skeleton Captain","552.5","543.75","1.6","1.9","1.0"},
                {"Pterosaur","562.75","539.5","1.2","1.2","1.0"},
                {"Ancient Earth Spirit","540.75","620.75","2.01","1.75","1.0"},
                {"Fire Elemental","560.75","516.5","1.32","1.85","1.0"},
                {"Ice Elemental","563.0","614.75","1.96","1.9","1.0"},
                {"Earth Elemental","546.0","613.5","1.23","1.2","1.0"},
                {"Frost Elemental","565.0","628.0","1.04","1.2","1.0"},
                {"Air Elemental","605.25","537.0","1.2","1.51","1.0"},
                {"Lava Spirit","601.25","590.5","1.2","2.1","1.0"},
                {"Cursed Tentacle","599.25","567.25","1.67","1.2","1.0"},
                {"Forest Witch","569.5","602.25","1.73","1.2","1.0"},
                {"Primal Shaman","605.0","683.0","1.21","1.4","1.0"},
                {"Minotaur","584.75","649.0","1.2","1.2","1.0"},
                {"Pack of Sabre Cats","630.0","689.75","1.27","1.2","1.0"},
                {"Ancient Spellcaster","610.0","596.25","1.03","1.2","1.0"},
                {"Emerald Oracle","629.5","648.0","1.6","1.43","1.0"},
                {"Obsidian Vapor Spirit","641.5","545.0","1.77","1.65","1.0"},
                {"Enraged Oracle","648.5","619.5","1.2","1.2","1.0"},
                {"Pack of Frost Wolves","653.0","628.5","1.23","1.2","1.0"},
                {"Wizard","678.25","613.5","1.2","1.96","1.0"},
                {"Minotaur Berserker","742.5","701.5","1.18","1.2","1.0"},
                {"Ethereal Cat Spirit","743.5","685.5","1.19","1.25","1.0"},
                {"Ethereal Wolf Spirit","757.75","791.5","1.5","2.27","1.0"},
                {"Ethereal Bird Spirit","747.75","788.75","1.2","1.38","1.0"},
                {"Three-Headed Hydra","787.0","714.75","1.58","1.2","1.0"},
                {"Primal Light Elemental","933.0","1029.0","1.7","1.99","1.0"},
                {"Primal Forest Elemental","928.0","1014.0","1.34","1.2","1.0"},
                {"Basilisk","745.0","919.0","1.2","1.52","1.0"},
                {"Fire Wyvern","607.25","975.0","1.8","1.2","1.0"},
                {"Fire Wyvern","607.25","975.0","1.8","1.2","1.0"},
                {"Golden Draconid","650.5","945.25","1.8","1.9","1.0"},
                {"Black Wyrm","660.75","960.75","1.2","1.2","1.0"},
                {"Ice Wyvern","666.75","964.25","1.2","1.2","1.0"},
                {"Bronze Dragon","664.0","939.5","1.2","1.2","1.0"},
                {"Ice Dragon","663.25","963.0","1.2","1.07","1.0"},
                {"Aether Dragon","683.25","925.25","1.97","2.06","1.0"},
                {"Emerald Wyrm","676.25","911.5","1.2","1.95","1.0"},
                {"Nether Dragon","684.25","945.25","1.2","1.2","1.0"},
                {"Obsidian Drake","673.5","984.0","1.47","1.79","1.0"},
                {"Golden Wyrm","711.0","992.0","1.9","1.19","1.0"},
                {"Ruby Dragon","711.0","957.0","1.2","1.2","1.0"},
                {"Red Dragon","706.0","990.0","1.53","1.2","1.0"},
                {"Emerald Drake","712.5","941.0","1.8","1.2","1.0"},
                {"Lightning Dragon","731.0","980.25","1.12","2.3","1.0"},
                {"Silver Wyrm","744.0","991.25","1.2","1.1","1.0"},
                {"Elder Dragon","738.25","930.0","1.14","1.8","1.0"},
                {"Blood Wyrm","767.5","984.0","1.75","1.2","1.0"},
                {"Sandskin Wyvern","776.75","950.5","1.1","1.5","1.0"},
                {"Sea Dragon","806.0","935.5","1.96","1.2","1.0"},
                {"Night Dragon","770.0","964.0","1.2","1.74","1.0"},
                {"Golden Dragon","777.0","976.5","1.2","1.01","1.0"},
                {"Reanimated Dragon","803.5","979.0","1.93","1.42","1.0"},
                {"Bronze Wyrm","817.5","959.5","2.23","1.2","1.0"},
                {"Fire Dragon","844.0","992.5","1.05","1.97","1.0"},
                {"Jade Drake","819.0","955.25","1.5","1.2","1.0"},
                {"Bloodrage Drake","830.0","918.25","1.2","1.9","1.0"},
                {"Enraged Drake","894.0","993.0","1.2","1.2","1.0"},
                {"Crystal Drake","911.0","1286.0","1.7","1.2","1.0"},
                {"Abyssal Drake","937.0","1286.0","1.9","1.2","1.0"},
                {"Forest Drake","939.5","998.25","1.25","1.99","1.0"},
                {"Earth Dragon","977.0","992.0","1.84","1.2","1.0"},
                {"Viridian Amphithere","976.0","1208.0","1.2","1.2","1.0"},
                {"Golden Amphitere","1028.0","1213.5","1.01","1.2","1.0"},
                {"Celestial Wyrm","1103.5","1237.0","1.8","1.4","1.0"},
                {"Golden Guardian Wyrm","1283.5","1629.0","1.8","1.2","1.0"},
                {"Quintessence Dragon","1353.0","1663.0","1.24","2.11","1.0"},
            };

            personality = new string[,]
            {
                {"absolutely brutal-looking","1.9","1.1"},
                {"ancient","0.8","2"},
                {"cunning","1.2","1.2"},
                {"delirious","0.6","0.8"},
                {"disgusting","1","0.7"},
                {"dumb","1","0.8"},
                {"enlightened","1.2","1.8"},
                {"fairly intelligent","1","1.2"},
                {"fat","1.1","0.9"},
                {"flustered","0.9","1.1"},
                {"focused","1.2","1"},
                {"gigantic","1.4","1"},
                {"hideous","1","1"},
                {"highly-scarred","1.4","1.1"},
                {"humongous","2","0.8"},
                {"immortal","100","1.1"},
                {"lazy","0.4","0.9"},
                {"minuscule","0.2","1.1"},
                {"muscle-bound","1.2","0.7"},
                {"old","0.8","1.5"},
                {"ordinary","1","1"},
                {"plagued","1.2","0.9"},
                {"possessed","1.8","100"},
                {"prodigious","1.6","0.8"},
                {"sad-looking","0.9","0.8"},
                {"savage","1.8","0.9"},
                {"scheming","1.3","1"},
                {"sick","0.3","0.9"},
                {"small","0.8","1"},
                {"staunch","1.15","1"},
                {"stupid","1","0.5"},
                {"terrifying","1","1.2"},
                {"tiny","0.7","1"},
                {"weak","0.5","1"},
                {"weary","0.6","0.9"}
            };
            Request();
        }
        private async void Request()
        {
            string[] array;
            string risposta;
            using (HttpClient client = new HttpClient())
            {
                string url = @"https://raw.githubusercontent.com/Yuuki2628/Adventure-Support-program/master/advNegaCalculator/additionalStats.txt";

                risposta = await client.GetStringAsync(url);
            }
            int count = risposta.Count(f => f == '}');
            array = new string[count];
            string temp = risposta;
            for (int i = 0; i < count; i++)
            {
                array[i] = temp.Substring(1, temp.IndexOf('-') - 1);
                array[i].Replace("\n", "");
                array[i].Replace("-", "");
            }

            for (int i = 0; i < count; i++)
            {
                Append();
                string value = array[i];
                for (int p = 0; p < 6; p++)
                {
                    stats[enemiesNumber, p] = value.Substring(0, value.IndexOf(',') - 1);
                    value.Remove(0, value.IndexOf(','));
                }
            }
        }

        private void Append()
        {
            enemiesNumber++;
            string[,] array = new string[enemiesNumber, 6];
            for (int i = 0; i < enemiesNumber; i++)
                for (int p = 0; p < 6; p++)
                    array[i, p] = stats[i, p];
            stats = array;
        }
    }
}