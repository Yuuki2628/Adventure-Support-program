using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advAssistProgram
{
    public partial class FrmAdventureSupport : Form
    {
        StatsManager s;
        int exeTimes = 0;

        public FrmAdventureSupport()
        {
            InitializeComponent();

            s = new StatsManager();

            Reload();
        }

        private void btnElaborate_Click(object sender, EventArgs e)
        {
            if (txtGoldInput.Text == "")
                MessageBox.Show("You have to input a number in the text box", "You forgot your input");
            else
            {
                string input = txtGoldInput.Text;
                while (input.IndexOf(',') >= 0)
                    input = input.Remove(input.IndexOf(','), 1);

                int output;

                if (!int.TryParse(input, out output))
                    output = 0;

                output = Convert.ToInt32(output * 0.90) - 1;

                txtGoldInput.Text = output.ToString();
            }
        }

        private void cmbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool part = false;
            for (int i = 0; i < s.getEnemiesCount() && !part; i++)
            {
                if (cmbSelection.Text == s.getCreatureName(i))
                    part = true;
            }
            if (part)//outputs the stats of the enemy
            {
                lblHP2.Text = s.getHP(cmbSelection.SelectedIndex);
                lblDiplomacy2.Text = s.getDiplomacy(cmbSelection.SelectedIndex);
                lblPhysicalDef2.Text = s.getPhysicalDefence(cmbSelection.SelectedIndex);
                lblMagicalDef2.Text = s.getMagicalDefence(cmbSelection.SelectedIndex);
                lblPersuasionDef2.Text = s.getPersuasionDefence(cmbSelection.SelectedIndex);
                if (exeTimes != 0)
                {
                    if (cmbPersonality.SelectedIndex < cmbPersonality.Items.Count / 2)
                    {
                        cmbPersonality.SelectedIndex += 1; //updates all the stats that are not updated here triggering the below cycle
                        cmbPersonality.SelectedIndex -= 1;
                    }
                    else
                    {
                        cmbPersonality.SelectedIndex -= 1; //updates all the stats that are not updated here triggering the below cycle
                        cmbPersonality.SelectedIndex += 1;
                    }
                }
            }
            else
                MessageBox.Show("You can't get the stats of a non-existent creature", "Error");
        }

        private void cmbPersonality_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool part = false;
            for (int i = 0; i < s.getPersonalityCount() && !part; i++)
            {
                if (cmbPersonality.Text == s.getPersonality(i))
                    part = true;
            }
            if (part)
            {
                int trascendedMultiplier = 1; //multiplies every stat, if trascended is selected it'll multiply every hp stat by 4
                if (exeTimes == 0)
                    exeTimes++;
                if (cbxTrascended.Checked == true)
                    trascendedMultiplier = 4;
                string stringHpResistance = s.getDef(cmbPersonality.SelectedIndex), stingDiplomacyResistance = s.getDDef(cmbPersonality.SelectedIndex);
                lblPersonalityValue2.Text = stringHpResistance + " / " + stingDiplomacyResistance;
                stringHpResistance = stringHpResistance.Replace(".", ",");
                stingDiplomacyResistance = stingDiplomacyResistance.Replace(".", ",");

                double hpResistance = Convert.ToDouble(stringHpResistance), diplomacyResistance = Convert.ToDouble(stingDiplomacyResistance);
                // conversion of the hps to int to be able to use them to calculate the final hps
                int hp, dipl;
                if (cmbSelection.SelectedIndex < 206)
                {
                    hp = Convert.ToInt32(s.getHP(cmbSelection.SelectedIndex).Remove(s.getHP(cmbSelection.SelectedIndex).IndexOf('.')));
                    dipl = Convert.ToInt32(s.getDiplomacy(cmbSelection.SelectedIndex).Remove(s.getDiplomacy(cmbSelection.SelectedIndex).IndexOf('.')));
                }
                else
                {
                    hp = Convert.ToInt32(s.getHP(cmbSelection.SelectedIndex));
                    dipl = Convert.ToInt32(s.getDiplomacy(cmbSelection.SelectedIndex));
                }

                hpResistance = hpResistance * hp * trascendedMultiplier;
                diplomacyResistance = diplomacyResistance * dipl * trascendedMultiplier;

                Math.Round(hpResistance, 1);
                Math.Round(diplomacyResistance, 1); //round them to 1 decimal 

                double stabHp = hpResistance, magicHp = hpResistance, diplHp = diplomacyResistance;

                stringHpResistance = Convert.ToString(hpResistance).Replace(",", ".");
                stingDiplomacyResistance = Convert.ToString(diplomacyResistance).Replace(",", ".");

                //turns the various weaknesses into doubles to use them
                stabHp = stabHp * Convert.ToDouble(s.getPhysicalDefence(cmbSelection.SelectedIndex).Replace(".", ","));
                magicHp = magicHp * Convert.ToDouble(s.getMagicalDefence(cmbSelection.SelectedIndex).Replace(".", ","));
                diplHp = diplHp * Convert.ToDouble(s.getPersuasionDefence(cmbSelection.SelectedIndex).Replace(".", ","));

                string fS, sM, fD;

                fS = Convert.ToString(stabHp).Replace(",", ".");
                sM = Convert.ToString(magicHp).Replace(",", ".");
                fD = Convert.ToString(diplHp).Replace(",", ".");

                if (fS.IndexOf(".") < 0) //if they're missing the .0 at th end this adds it
                    fS += ".0";
                if (sM.IndexOf(".") < 0)
                    sM += ".0";
                if (fD.IndexOf(".") < 0)
                    fD += ".0";

                //all the math is done, this outputs the results
                lblStabEverything2.Text = fS;
                lblMagicEverything2.Text = sM;
                lblDiplomacyEverything2.Text = fD;
            }
            else
                if (exeTimes == 0) //if it's the first cycle it'll skip the error message
                MessageBox.Show("You can't get the personality of a non-existent creature", "Error");

        }

        private void cbxTrascended_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbSelection.SelectedIndex <= cmbSelection.Items.Count / 2)
            {
                cmbSelection.SelectedIndex += 1;
                cmbSelection.SelectedIndex -= 1;
            }
            else
            {
                cmbSelection.SelectedIndex -= 1;
                cmbSelection.SelectedIndex += 1;
            }
        }

        private void Reload()
        {
            cmbPersonality.Items.Clear();
            cmbSelection.Items.Clear();
            for (int i = 0; i < s.getEnemiesCount(); i++)
            {
                cmbSelection.Items.Add(s.getName(i));
            }
            for (int i = 0; i < s.getPersonalityCount(); i++)
            {
                if (s.getPersonality(i) != null)
                    cmbPersonality.Items.Add(s.getPersonality(i));
            }
            cmbSelection.SelectedIndex = 0;
            cmbPersonality.SelectedIndex = 0;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void tmrReload_Tick(object sender, EventArgs e)
        {
            Reload();
            tmrReload.Enabled = false;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            s = new StatsManager();

            tmrReload.Enabled = true;
        }
    }
}