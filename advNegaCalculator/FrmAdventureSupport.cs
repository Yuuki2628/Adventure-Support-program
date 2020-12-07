using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advAssistProgram
{
    public partial class FrmAdventureSupport : Form
    {
        StatsManager s = new StatsManager(@"C:\stats.txt");

        public FrmAdventureSupport()
        {
            InitializeComponent();


            for (int i = 0; i < s.getEnemiesCount(); i++)
            {
                cmbSelection.Items.Add(s.getName(i));
            }
            cmbSelection.SelectedIndex = 0;
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cmbSelection.Items.Clear();

            s = new StatsManager(txtPath.Text);

            for (int i = 0; i < s.getEnemiesCount(); i++)
            {
                cmbSelection.Items.Add(s.getName(i));
            }
            cmbSelection.SelectedIndex = 0;
        }

        private void btnUpdateStats_Click(object sender, EventArgs e)
        {
            if (cmbSelection.Text != "")
            {
                lblHP2.Text = s.getHP(cmbSelection.SelectedIndex);
                lblDiplomacy2.Text = s.getDiplomacy(cmbSelection.SelectedIndex);
                lblPhysicalDef2.Text = s.getPhysicalDefence(cmbSelection.SelectedIndex);
                lblMagicalDef2.Text = s.getMagicalDefence(cmbSelection.SelectedIndex);
                lblPersuasionDef2.Text = s.getPersuasionDefence(cmbSelection.SelectedIndex);
            }
            else
                MessageBox.Show("You can't get the stats of a non-existent creature", "Error");
        }
    }
}