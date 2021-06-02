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
                    cmbPersonality.SelectedIndex += 1;//updates all the stats that are not updated here triggering the below cycle
                    cmbPersonality.SelectedIndex -= 1;
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
                int multiplier = 1; //multiplies every stat, if trascended is selected it'll multiply every hp stat by 4
                if (exeTimes == 0)
                    exeTimes++;
                if (cbxTrascended.Checked == true)
                    multiplier = 4;
                string hpDef = s.getDef(cmbPersonality.SelectedIndex), diplDef = s.getDDef(cmbPersonality.SelectedIndex);
                lblPersonalityValue2.Text = s.getDef(cmbPersonality.SelectedIndex) + " / " + s.getDDef(cmbPersonality.SelectedIndex);
                hpDef = hpDef.Replace(".", ",");
                diplDef = diplDef.Replace(".", ",");

                double hp = Convert.ToDouble(hpDef), dipl = Convert.ToDouble(diplDef);
                // conversion of the hps to int to be able to use them to calculate the final hps
                int hpO, diplO;
                if (cmbSelection.SelectedIndex < 206)
                {
                    hpO = Convert.ToInt32(s.getHP(cmbSelection.SelectedIndex).Remove(s.getHP(cmbSelection.SelectedIndex).IndexOf('.')));
                    diplO = Convert.ToInt32(s.getDiplomacy(cmbSelection.SelectedIndex).Remove(s.getDiplomacy(cmbSelection.SelectedIndex).IndexOf('.')));
                }
                else
                {
                    hpO = Convert.ToInt32(s.getHP(cmbSelection.SelectedIndex).Replace(".", ""));
                    diplO = Convert.ToInt32(s.getDiplomacy(cmbSelection.SelectedIndex).Replace(".", ""));
                }

                hp = hp * hpO * multiplier;
                dipl = dipl * diplO * multiplier;

                Math.Round(hp, 1);
                Math.Round(dipl, 1); //round them to 1 decimal 

                double finalStab = hp, finalMagic = hp, finalDiplo = dipl;

                hpDef = Convert.ToString(hp).Replace(",", ".");
                diplDef = Convert.ToString(dipl).Replace(",", ".");

                if (hpDef.IndexOf(".") < 0) //if they're missing the .0 at th end this adds it
                    hpDef += ".0";
                if (diplDef.IndexOf(".") < 0)
                    diplDef += ".0";

                //turns the various weaknesses into doubles to use them
                finalStab = finalStab * Convert.ToDouble(s.getPhysicalDefence(cmbSelection.SelectedIndex).Replace(".", ","));
                finalMagic = finalMagic * Convert.ToDouble(s.getMagicalDefence(cmbSelection.SelectedIndex).Replace(".", ","));
                finalDiplo = finalDiplo * Convert.ToDouble(s.getPersuasionDefence(cmbSelection.SelectedIndex).Replace(".", ","));

                string fS, sM, fD;

                fS = Convert.ToString(finalStab).Replace(",", ".");
                sM = Convert.ToString(finalMagic).Replace(",", ".");
                fD = Convert.ToString(finalDiplo).Replace(",", ".");

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

        private void lklHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the stats shown here are not final, they can increase or decrease according to the win rate.", "Stats");
        }

        private void lklDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://discord.gg/vQQHZWR6dn");
            Process.Start(sInfo);
        }

        private void cbxTrascended_CheckedChanged(object sender, EventArgs e)
        {
            cmbSelection.SelectedIndex += 1;
            cmbSelection.SelectedIndex -= 1;
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
    }
}