//-----------------------------------------------------------------------
// <copyright file="frmPrincipale.cs" company = "HansIV4" >
//     Copyright (c) HansIV4. All rights reserved.
//      Name: HansIV4
//      Goal: An app that will randomly select one of the enabled elements in the UI
//      Date: 01/04/2018
// </copyright>
//-----------------------------------------------------------------------

namespace R6MapPicker
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main form
    /// </summary>
    public partial class FrmMain : Form
    {
        /// <summary>
        /// The program controller manages all the logic behind the program
        /// </summary>
        private ProgramController controller = new ProgramController();
        bool chaletActive = true;


        /// <summary>
        ///  Initializes a new instance of the <see cref="FrmMain" /> class.
        /// </summary>
        public FrmMain()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Enables all of the check boxes
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default EventArgs</param>
        private void BrtnSelectionnerTous_Click(object sender, EventArgs e)
        {
            this.chkBanque.Checked = true;
            this.chkClubhouse.Checked = true;
            this.chkOregon.Checked = true;
            this.chkCafe.Checked = true;
            this.chkConsulat.Checked = true;
            this.chkChalet.Checked = true;
            this.chkFrontiere.Checked = true;
            this.chkLittoral.Checked = true;
            this.chkGratteCiel.Checked = true;
        }

        /// <summary>
        /// disables all the check boxes
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default EventsArgs</param>
        private void BtnDeselectionnerTout_Click(object sender, EventArgs e)
        {
            this.chkBanque.Checked = false;
            this.chkClubhouse.Checked = false;
            this.chkOregon.Checked = false;
            this.chkCafe.Checked = false;
            this.chkConsulat.Checked = false;
            this.chkChalet.Checked = false;
            this.chkFrontiere.Checked = false;
            this.chkLittoral.Checked = false;
            this.chkGratteCiel.Checked = false;
        }

        /// <summary>
        /// the method called when the checkbox is changed
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default arguments</param>
        private void ChkBanque_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkBanque.Checked)
            {
                this.controller.EnableMap(0);
            }
            else
            {
                this.controller.DisableMap(0);
            }
        }

        /// <summary>
        /// the method called when the checkbox is changed
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default arguments</param>
        private void ChkClubhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkClubhouse.Checked)
            {
                this.controller.EnableMap(1);
            }
            else
            {
                this.controller.DisableMap(1);
            }
        }

        /// <summary>
        /// the method called when the checkbox is changed
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default arguments</param>
        private void ChkOregon_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkOregon.Checked)
            {
                this.controller.EnableMap(2);
            }
            else
            {
                this.controller.DisableMap(2);
            }
        }

        /// <summary>
        /// the method called when the checkbox is changed
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default arguments</param>
        private void ChkCafe_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCafe.Checked)
            {
                this.controller.EnableMap(3);
            }
            else
            {
                this.controller.DisableMap(3);
            }
        }

        /// <summary>
        /// the method called when the checkbox is changed
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default arguments</param>
        private void ChkConsulat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkConsulat.Checked)
            {
                this.controller.EnableMap(4);
            }
            else
            {
                this.controller.DisableMap(4);
            }
        }
     
        /// <summary>
        /// the method called when the checkbox is changed
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default arguments</param>
        private void ChkChalet_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkChalet.Checked)
            {
                this.controller.EnableMap(5);
            }
            else
            {
                this.controller.DisableMap(5);
            }
        }

        /// <summary>
        /// the method called when the checkbox is changed
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default arguments</param>
        private void ChkFrontiere_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFrontiere.Checked)
            {
                this.controller.EnableMap(6);
            }
            else
            {
                this.controller.DisableMap(6);
            }
        }

        /// <summary>
        /// the method called when the checkbox is changed
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default arguments</param>
        private void ChkLittoral_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkLittoral.Checked)
            {
                this.controller.EnableMap(7);
            }
            else
            {
                this.controller.DisableMap(7);
            }
        }

        /// <summary>
        /// the method called when the checkbox is changed
        /// </summary>
        /// <param name="sender">the default sender</param>
        /// <param name="e">the default arguments</param>
        private void ChkGratteCiel_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkGratteCiel.Checked)
            {
               this.controller.EnableMap(8);
            }
            else
            {
                this.controller.DisableMap(8);
            }
        }

        /// <summary>
        /// The button calls the application controller to select a random element and return its label
        /// </summary>
        /// <param name="sender">default sender</param>
        /// <param name="e">default args</param>
        private void BtnRandom_Click(object sender, EventArgs e)
        {
            if (this.controller.SelectRandomMap() != "-1")
            {
               this.lblResultat.Text = this.controller.SelectRandomMap();
            }
            else
            {
                MessageBox.Show("Tous les éléments sont désactivés. Veuillez en acviter au moins un.");
            }
        }

        private void picChalet_Click(object sender, EventArgs e)
        {

            if (chaletActive)
            {
                picChalet.Image = R6MapPicker.Properties.Resources.chaletGrey;
                chaletActive = false;
            }
            else
            {
                picChalet.Image = R6MapPicker.Properties.Resources.chaletColored;
                chaletActive = true;

            }
        }
    }
}
