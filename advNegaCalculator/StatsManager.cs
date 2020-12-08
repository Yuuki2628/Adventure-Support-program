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
            try //if it can't read the file it'll return -1, if it can it'll return 0
            {
                sr = new StreamReader(filePath);
                numberFinder = new StreamReader(filePath);
                personalityFinder = new StreamReader(filePath);
            }
            catch 
            { 
                return -1;
            }

            //numberFinder finds how many creature's stats I know
            string counter = numberFinder.ReadLine();
            while(counter != null)
            {
                if (counter.Contains("Is a boss"))
                    enemiesNumber++;
                counter = numberFinder.ReadLine();
            }

            stats = new string[enemiesNumber, 6];

            //personalityFinder finds how many personalities are in the file
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
            //inputting the personality values from stats.txt
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
                if (line.Contains(':') && !line.Contains("Is a boss") && !line.Contains('"')) //adding only useful lines to the array
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

            for(i = 0; i < enemiesNumber; i ++)
            {
                //j = 0, adding the enemies names to the array
                string name = stats[i, 0];
                name = name.Remove(0, 9);
                name = name.Remove(name.IndexOf(" has "));
                stats[i, 0] = name;

                string value;

                for(j = 1; j < 6; j++) //adding an enemy's stats to the array
                {
                    value = stats[i, j];
                    value = value.Substring(value.IndexOf("[") + 1, value.IndexOf("]") - value.IndexOf("[") - 1);
                    stats[i, j] = value;
                }
            }

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
            return 0;
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