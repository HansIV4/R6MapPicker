namespace R6MapPicker
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.chkFrontiere.CheckedChanged += new System.EventHandler(this.chkFrontiere_CheckedChanged);
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
            this.chkCafe.CheckedChanged += new System.EventHandler(this.chkCafe_CheckedChanged);
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
            this.chkBanque.CheckedChanged += new System.EventHandler(this.chkBanque_CheckedChanged);
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
            this.chkLittoral.CheckedChanged += new System.EventHandler(this.chkLittoral_CheckedChanged);
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
            this.chkConsulat.CheckedChanged += new System.EventHandler(this.chkConsulat_CheckedChanged);
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
            this.chkClubhouse.CheckedChanged += new System.EventHandler(this.chkClubhouse_CheckedChanged);
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
            this.chkGratteCiel.CheckedChanged += new System.EventHandler(this.chkGratteCiel_CheckedChanged);
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
            this.chkChalet.CheckedChanged += new System.EventHandler(this.chkChalet_CheckedChanged);
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
            this.chkOregon.CheckedChanged += new System.EventHandler(this.chkOregon_CheckedChanged);
            // 
            // btnSelectionnerTous
            // 
            this.btnSelectionnerTous.Location = new System.Drawing.Point(45, 169);
            this.btnSelectionnerTous.Name = "btnSelectionnerTous";
            this.btnSelectionnerTous.Size = new System.Drawing.Size(165, 32);
            this.btnSelectionnerTous.TabIndex = 9;
            this.btnSelectionnerTous.Text = "Sélectionner tous";
            this.btnSelectionnerTous.UseVisualStyleBackColor = true;
            this.btnSelectionnerTous.Click += new System.EventHandler(this.Button1_Click);
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
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 274);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Sélection de cartes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFrontiere;
        private System.Windows.Forms.CheckBox chkCafe;
        private System.Windows.Forms.CheckBox chkBanque;
        private System.Windows.Forms.CheckBox chkLittoral;
        private System.Windows.Forms.CheckBox chkConsulat;
        private System.Windows.Forms.CheckBox chkClubhouse;
        private System.Windows.Forms.CheckBox chkGratteCiel;
        private System.Windows.Forms.CheckBox chkChalet;
        private System.Windows.Forms.CheckBox chkOregon;
        private System.Windows.Forms.Button btnSelectionnerTous;
        private System.Windows.Forms.Button btnDeselectionnerTout;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblResultat;
    }
}

