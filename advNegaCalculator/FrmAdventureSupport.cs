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
        StatsManager s;

        public FrmAdventureSupport()
        {
            InitializeComponent();
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

                int output = Convert.ToInt32(Convert.ToInt32(input) * 0.90) - 1;

                txtGoldInput.Text = output.ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            s = new StatsManager(txtPath.Text);

            for(int i = 0; i < s.getEnemiesCount(); i ++)
            {
                cmbSelection.Items.Add(s.getName(i));
            }
        }
    }
}