//-----------------------------------------------------------------------
// <copyright file="frmPrincipale.Designer.cs" company = "HansIV4" >
//     Copyright (c) HansIV4. All rights reserved.
//      Name: HansIV4
//      Goal: The UI designer for an app that will randomly select one of the enabled elements in the UI
//      Date: 01/04/2018
// </copyright>
//-----------------------------------------------------------------------
namespace R6MapPicker
{
    /// <summary>
    /// The code behind for the UI
    /// </summary>
    public partial class FrmMain
    {
        /// <summary>
        /// UI checkbox element
        /// </summary>
        private System.Windows.Forms.CheckBox chkFrontiere;

        /// <summary>
        /// UI checkbox element
        /// </summary>
        private System.Windows.Forms.CheckBox chkCafe;

        /// <summary>
        /// UI checkbox element
        /// </summary>
        private System.Windows.Forms.CheckBox chkBanque;
        
        /// <summary>
        /// UI checkbox element
        /// </summary>
        private System.Windows.Forms.CheckBox chkLittoral;

        /// <summary>
        /// UI checkbox element
        /// </summary>
        private System.Windows.Forms.CheckBox chkConsulat;

        /// <summary>
        /// UI checkbox element
        /// </summary>
        private System.Windows.Forms.CheckBox chkClubhouse;

        /// <summary>
        /// UI checkbox element
        /// </summary>
        private System.Windows.Forms.CheckBox chkGratteCiel;

        /// <summary>
        /// UI checkbox element
        /// </summary>
        private System.Windows.Forms.CheckBox chkChalet;

        /// <summary>
        /// UI checkbox element
        /// </summary>
        private System.Windows.Forms.CheckBox chkOregon;

        /// <summary>
        /// UI button element
        /// </summary>
        private System.Windows.Forms.Button btnSelectionnerTous;

        /// <summary>
        /// UI button element
        /// </summary>
        private System.Windows.Forms.Button btnDeselectionnerTout;

        /// <summary>
        /// UI button element
        /// </summary>
        private System.Windows.Forms.Button btnRandom;

        /// <summary>
        /// UI label element
        /// </summary>
        private System.Windows.Forms.Label lblResultat;
        
        /// <summary>
        /// Mandatory variables for the CTOR
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// garbage collector
        /// </summary>
        /// <param name="disposing">true if the managed resources need to be deleted, false if not</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Method for Designer Support - Do not change 
        /// the contents of this method with the Code Editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.chkFrontiere = new System.Windows.Forms.CheckBox();
            this.chkCafe = new System.Windows.Forms.CheckBox();
            this.chkBanque = new System.Windows.Forms.CheckBox();
            this.chkLittoral = new System.Windows.Forms.CheckBox();
            this.chkConsulat = new System.Windows.Forms.CheckBox();
            this.chkClubhouse = new System.Windows.Forms.CheckBox();
            this.chkGratteCiel = new System.Windows.Forms.CheckBox();
            this.chkChalet = new System.Windows.Forms.CheckBox();
            this.chkOregon = new System.Windows.Forms.CheckBox();
            this.btnSelectionnerTous = new System.Windows.Forms.Button();
            this.btnDeselectionnerTout = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.picChalet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChalet)).BeginInit();
            this.SuspendLayout();
            // 
            // chkFrontiere
            // 
            this.chkFrontiere.AutoSize = true;
            this.chkFrontiere.Checked = true;
            this.chkFrontiere.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFrontiere.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFrontiere.Location = new System.Drawing.Point(36, 98);
            this.chkFrontiere.Name = "chkFrontiere";
            this.chkFrontiere.Size = new System.Drawing.Size(129, 33);
            this.chkFrontiere.TabIndex = 0;
            this.chkFrontiere.Text = "Frontière";
            this.chkFrontiere.UseVisualStyleBackColor = true;
            this.chkFrontiere.CheckedChanged += new System.EventHandler(this.ChkFrontiere_CheckedChanged);
            // 
            // chkCafe
            // 
            this.chkCafe.AutoSize = true;
            this.chkCafe.Checked = true;
            this.chkCafe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCafe.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCafe.Location = new System.Drawing.Point(36, 68);
            this.chkCafe.Name = "chkCafe";
            this.chkCafe.Size = new System.Drawing.Size(83, 33);
            this.chkCafe.TabIndex = 1;
            this.chkCafe.Text = "Cafe";
            this.chkCafe.UseVisualStyleBackColor = true;
            this.chkCafe.CheckedChanged += new System.EventHandler(this.ChkCafe_CheckedChanged);
            // 
            // chkBanque
            // 
            this.chkBanque.AutoSize = true;
            this.chkBanque.Checked = true;
            this.chkBanque.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBanque.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBanque.Location = new System.Drawing.Point(36, 38);
            this.chkBanque.Name = "chkBanque";
            this.chkBanque.Size = new System.Drawing.Size(114, 33);
            this.chkBanque.TabIndex = 2;
            this.chkBanque.Text = "Banque";
            this.chkBanque.UseVisualStyleBackColor = true;
            this.chkBanque.CheckedChanged += new System.EventHandler(this.ChkBanque_CheckedChanged);
            // 
            // chkLittoral
            // 
            this.chkLittoral.AutoSize = true;
            this.chkLittoral.Checked = true;
            this.chkLittoral.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLittoral.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLittoral.Location = new System.Drawing.Point(168, 98);
            this.chkLittoral.Name = "chkLittoral";
            this.chkLittoral.Size = new System.Drawing.Size(107, 33);
            this.chkLittoral.TabIndex = 3;
            this.chkLittoral.Text = "Littoral";
            this.chkLittoral.UseVisualStyleBackColor = true;
            this.chkLittoral.CheckedChanged += new System.EventHandler(this.ChkLittoral_CheckedChanged);
            // 
            // chkConsulat
            // 
            this.chkConsulat.AutoSize = true;
            this.chkConsulat.Checked = true;
            this.chkConsulat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsulat.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConsulat.Location = new System.Drawing.Point(168, 68);
            this.chkConsulat.Name = "chkConsulat";
            this.chkConsulat.Size = new System.Drawing.Size(126, 33);
            this.chkConsulat.TabIndex = 4;
            this.chkConsulat.Text = "Consulat";
            this.chkConsulat.UseVisualStyleBackColor = true;
            this.chkConsulat.CheckedChanged += new System.EventHandler(this.ChkConsulat_CheckedChanged);
            // 
            // chkClubhouse
            // 
            this.chkClubhouse.AutoSize = true;
            this.chkClubhouse.Checked = true;
            this.chkClubhouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClubhouse.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClubhouse.Location = new System.Drawing.Point(168, 38);
            this.chkClubhouse.Name = "chkClubhouse";
            this.chkClubhouse.Size = new System.Drawing.Size(144, 33);
            this.chkClubhouse.TabIndex = 5;
            this.chkClubhouse.Text = "Clubhouse";
            this.chkClubhouse.UseVisualStyleBackColor = true;
            this.chkClubhouse.CheckedChanged += new System.EventHandler(this.ChkClubhouse_CheckedChanged);
            // 
            // chkGratteCiel
            // 
            this.chkGratteCiel.AutoSize = true;
            this.chkGratteCiel.Checked = true;
            this.chkGratteCiel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGratteCiel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGratteCiel.Location = new System.Drawing.Point(310, 98);
            this.chkGratteCiel.Name = "chkGratteCiel";
            this.chkGratteCiel.Size = new System.Drawing.Size(143, 33);
            this.chkGratteCiel.TabIndex = 6;
            this.chkGratteCiel.Text = "Gratte-Ciel";
            this.chkGratteCiel.UseVisualStyleBackColor = true;
            this.chkGratteCiel.CheckedChanged += new System.EventHandler(this.ChkGratteCiel_CheckedChanged);
            // 
            // chkChalet
            // 
            this.chkChalet.AutoSize = true;
            this.chkChalet.Checked = true;
            this.chkChalet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChalet.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChalet.Location = new System.Drawing.Point(310, 68);
            this.chkChalet.Name = "chkChalet";
            this.chkChalet.Size = new System.Drawing.Size(102, 33);
            this.chkChalet.TabIndex = 7;
            this.chkChalet.Text = "Chalet";
            this.chkChalet.UseVisualStyleBackColor = true;
            this.chkChalet.CheckedChanged += new System.EventHandler(this.ChkChalet_CheckedChanged);
            // 
            // chkOregon
            // 
            this.chkOregon.AutoSize = true;
            this.chkOregon.Checked = true;
            this.chkOregon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOregon.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOregon.Location = new System.Drawing.Point(310, 38);
            this.chkOregon.Name = "chkOregon";
            this.chkOregon.Size = new System.Drawing.Size(110, 33);
            this.chkOregon.TabIndex = 8;
            this.chkOregon.Text = "Oregon";
            this.chkOregon.UseVisualStyleBackColor = true;
            this.chkOregon.CheckedChanged += new System.EventHandler(this.ChkOregon_CheckedChanged);
            // 
            // btnSelectionnerTous
            // 
            this.btnSelectionnerTous.Location = new System.Drawing.Point(45, 169);
            this.btnSelectionnerTous.Name = "btnSelectionnerTous";
            this.btnSelectionnerTous.Size = new System.Drawing.Size(165, 32);
            this.btnSelectionnerTous.TabIndex = 9;
            this.btnSelectionnerTous.Text = "Sélectionner tous";
            this.btnSelectionnerTous.UseVisualStyleBackColor = true;
            this.btnSelectionnerTous.Click += new System.EventHandler(this.BrtnSelectionnerTous_Click);
            // 
            // btnDeselectionnerTout
            // 
            this.btnDeselectionnerTout.Location = new System.Drawing.Point(233, 169);
            this.btnDeselectionnerTout.Name = "btnDeselectionnerTout";
            this.btnDeselectionnerTout.Size = new System.Drawing.Size(165, 32);
            this.btnDeselectionnerTout.TabIndex = 10;
            this.btnDeselectionnerTout.Text = "Déselectionner tous";
            this.btnDeselectionnerTout.UseVisualStyleBackColor = true;
            this.btnDeselectionnerTout.Click += new System.EventHandler(this.BtnDeselectionnerTout_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(421, 169);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(123, 32);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "Sélectionner";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(483, 36);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(106, 35);
            this.lblResultat.TabIndex = 12;
            this.lblResultat.Text = "résultat";
            // 
            // picChalet
            // 
            this.picChalet.Image = global::R6MapPicker.Properties.Resources.chaletColored;
            this.picChalet.Location = new System.Drawing.Point(36, 245);
            this.picChalet.Name = "picChalet";
            this.picChalet.Size = new System.Drawing.Size(373, 192);
            this.picChalet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChalet.TabIndex = 13;
            this.picChalet.TabStop = false;
            this.picChalet.Click += new System.EventHandler(this.picChalet_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 689);
            this.Controls.Add(this.picChalet);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnDeselectionnerTout);
            this.Controls.Add(this.btnSelectionnerTous);
            this.Controls.Add(this.chkOregon);
            this.Controls.Add(this.chkChalet);
            this.Controls.Add(this.chkGratteCiel);
            this.Controls.Add(this.chkClubhouse);
            this.Controls.Add(this.chkConsulat);
            this.Controls.Add(this.chkLittoral);
            this.Controls.Add(this.chkBanque);
            this.Controls.Add(this.chkCafe);
            this.Controls.Add(this.chkFrontiere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sélection de cartes";
            ((System.ComponentModel.ISupportInitialize)(this.picChalet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picChalet;
    }
}
