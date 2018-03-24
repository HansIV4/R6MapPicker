using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6MapPicker
{
    public partial class frmMain : Form
    {
        ProgramController controller = new ProgramController();

        public frmMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            chkBanque.Checked = true;
            chkClubhouse.Checked = true;
            chkOregon.Checked = true;
            chkCafe.Checked = true;
            chkConsulat.Checked = true;
            chkChalet.Checked = true;
            chkFrontiere.Checked = true;
            chkLittoral.Checked = true;
            chkGratteCiel.Checked = true;
        }

        private void BtnDeselectionnerTout_Click(object sender, EventArgs e)
        {
            chkBanque.Checked = false;
            chkClubhouse.Checked = false;
            chkOregon.Checked = false;
            chkCafe.Checked = false;
            chkConsulat.Checked = false;
            chkChalet.Checked = false;
            chkFrontiere.Checked = false;
            chkLittoral.Checked = false;
            chkGratteCiel.Checked = false;
        }

        private void chkBanque_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBanque.Checked)
            {
                controller.EnableMap(0);
            }
            else
            {
                controller.DisableMap(0);
            }

        }

        private void chkClubhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClubhouse.Checked)
            {
                controller.EnableMap(1);
            }
            else
            {
                controller.DisableMap(1);
            }
        }

        private void chkOregon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOregon.Checked)
            {
                controller.EnableMap(2);
            }
            else
            {
                controller.DisableMap(2);
            }
        }

        private void chkCafe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCafe.Checked)
            {
                controller.EnableMap(3);
            }
            else
            {
                controller.DisableMap(3);
            }
        }

        private void chkConsulat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsulat.Checked)
            {
                controller.EnableMap(4);
            }
            else
            {
                controller.DisableMap(4);
            }
        }

        private void chkChalet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChalet.Checked)
            {
                controller.EnableMap(5);
            }
            else
            {
                controller.DisableMap(5);
            }
        }

        private void chkFrontiere_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrontiere.Checked)
            {
                controller.EnableMap(6);
            }
            else
            {
                controller.DisableMap(6);
            }
        }

        private void chkLittoral_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLittoral.Checked)
            {
                controller.EnableMap(7);
            }
            else
            {
                controller.DisableMap(7);
            }
        }

        private void chkGratteCiel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGratteCiel.Checked)
            {
                controller.EnableMap(8);
            }
            else
            {
                controller.DisableMap(8);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (controller.SelectRandomMap() != "-1")
            {
                lblResultat.Text = controller.SelectRandomMap();
            }
            else
            {
                MessageBox.Show("Tous les éléments sont désactivés. Veuillez en acviter au moins un.");
            }
        }
    }
}
