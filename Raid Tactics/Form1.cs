using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raid_Tactics  
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmboDiff.Items.Add("Normal");
            cmboDiff.Items.Add("Heroic");
            cmboDiff.Items.Add("Mythic");
        }

        private void btnWrathion_Click(object sender, EventArgs e)
        {
            lblTactics.ResetText();
            lblTactics.Text = "Wrathion";
            /*  Image img1;
              img1.*/
        }

        private void cmboDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            object odiff = cmboDiff.SelectedItem;
            string difficulty;
            difficulty = Convert.ToString(odiff);
            lblTactics.Text = difficulty;
        }
    }
        }
