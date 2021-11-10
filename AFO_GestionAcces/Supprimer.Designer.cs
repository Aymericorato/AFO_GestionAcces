
namespace AFO_GestionAcces
{
    partial class Supprimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrbxPersonne = new System.Windows.Forms.GroupBox();
            this.CbxPersonne = new System.Windows.Forms.ComboBox();
            this.GrbxBatiment = new System.Windows.Forms.GroupBox();
            this.CbxBatiment = new System.Windows.Forms.ComboBox();
            this.GrbxProfil = new System.Windows.Forms.GroupBox();
            this.CbxProfil = new System.Windows.Forms.ComboBox();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RbnPersonne = new System.Windows.Forms.RadioButton();
            this.RbnBatiment = new System.Windows.Forms.RadioButton();
            this.RbnProfil = new System.Windows.Forms.RadioButton();
            this.GrbxPersonne.SuspendLayout();
            this.GrbxBatiment.SuspendLayout();
            this.GrbxProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbxPersonne
            // 
            this.GrbxPersonne.BackColor = System.Drawing.Color.Red;
            this.GrbxPersonne.Controls.Add(this.CbxPersonne);
            this.GrbxPersonne.Location = new System.Drawing.Point(13, 13);
            this.GrbxPersonne.Name = "GrbxPersonne";
            this.GrbxPersonne.Size = new System.Drawing.Size(250, 187);
            this.GrbxPersonne.TabIndex = 0;
            this.GrbxPersonne.TabStop = false;
            this.GrbxPersonne.Text = "Personne";
            // 
            // CbxPersonne
            // 
            this.CbxPersonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPersonne.FormattingEnabled = true;
            this.CbxPersonne.Location = new System.Drawing.Point(7, 27);
            this.CbxPersonne.Name = "CbxPersonne";
            this.CbxPersonne.Size = new System.Drawing.Size(151, 28);
            this.CbxPersonne.TabIndex = 0;
            // 
            // GrbxBatiment
            // 
            this.GrbxBatiment.BackColor = System.Drawing.Color.Green;
            this.GrbxBatiment.Controls.Add(this.CbxBatiment);
            this.GrbxBatiment.Location = new System.Drawing.Point(391, 13);
            this.GrbxBatiment.Name = "GrbxBatiment";
            this.GrbxBatiment.Size = new System.Drawing.Size(250, 187);
            this.GrbxBatiment.TabIndex = 1;
            this.GrbxBatiment.TabStop = false;
            this.GrbxBatiment.Text = "Batiment";
            // 
            // CbxBatiment
            // 
            this.CbxBatiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxBatiment.FormattingEnabled = true;
            this.CbxBatiment.Location = new System.Drawing.Point(7, 27);
            this.CbxBatiment.Name = "CbxBatiment";
            this.CbxBatiment.Size = new System.Drawing.Size(151, 28);
            this.CbxBatiment.TabIndex = 0;
            // 
            // GrbxProfil
            // 
            this.GrbxProfil.BackColor = System.Drawing.Color.Blue;
            this.GrbxProfil.Controls.Add(this.CbxProfil);
            this.GrbxProfil.Location = new System.Drawing.Point(13, 206);
            this.GrbxProfil.Name = "GrbxProfil";
            this.GrbxProfil.Size = new System.Drawing.Size(250, 210);
            this.GrbxProfil.TabIndex = 2;
            this.GrbxProfil.TabStop = false;
            this.GrbxProfil.Text = "Profil";
            // 
            // CbxProfil
            // 
            this.CbxProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxProfil.FormattingEnabled = true;
            this.CbxProfil.Location = new System.Drawing.Point(7, 27);
            this.CbxProfil.Name = "CbxProfil";
            this.CbxProfil.Size = new System.Drawing.Size(151, 28);
            this.CbxProfil.TabIndex = 0;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.Color.Yellow;
            this.BtnSupprimer.Location = new System.Drawing.Point(391, 206);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(250, 210);
            this.BtnSupprimer.TabIndex = 3;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Que voulez vous supprimer ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RbnPersonne
            // 
            this.RbnPersonne.AutoSize = true;
            this.RbnPersonne.Checked = true;
            this.RbnPersonne.Location = new System.Drawing.Point(219, 485);
            this.RbnPersonne.Name = "RbnPersonne";
            this.RbnPersonne.Size = new System.Drawing.Size(89, 24);
            this.RbnPersonne.TabIndex = 5;
            this.RbnPersonne.TabStop = true;
            this.RbnPersonne.Text = "Personne";
            this.RbnPersonne.UseVisualStyleBackColor = true;
            this.RbnPersonne.CheckedChanged += new System.EventHandler(this.RbnPersonne_CheckedChanged);
            // 
            // RbnBatiment
            // 
            this.RbnBatiment.AutoSize = true;
            this.RbnBatiment.Location = new System.Drawing.Point(314, 485);
            this.RbnBatiment.Name = "RbnBatiment";
            this.RbnBatiment.Size = new System.Drawing.Size(90, 24);
            this.RbnBatiment.TabIndex = 6;
            this.RbnBatiment.Text = "Batiment";
            this.RbnBatiment.UseVisualStyleBackColor = true;
            this.RbnBatiment.CheckedChanged += new System.EventHandler(this.RbnBatiment_CheckedChanged);
            // 
            // RbnProfil
            // 
            this.RbnProfil.AutoSize = true;
            this.RbnProfil.Location = new System.Drawing.Point(410, 485);
            this.RbnProfil.Name = "RbnProfil";
            this.RbnProfil.Size = new System.Drawing.Size(65, 24);
            this.RbnProfil.TabIndex = 7;
            this.RbnProfil.Text = "Profil";
            this.RbnProfil.UseVisualStyleBackColor = true;
            this.RbnProfil.CheckedChanged += new System.EventHandler(this.RbnProfil_CheckedChanged);
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.RbnProfil);
            this.Controls.Add(this.RbnBatiment);
            this.Controls.Add(this.RbnPersonne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.GrbxProfil);
            this.Controls.Add(this.GrbxBatiment);
            this.Controls.Add(this.GrbxPersonne);
            this.Name = "Supprimer";
            this.Text = "Supprimer";
            this.Load += new System.EventHandler(this.Supprimer_Load);
            this.GrbxPersonne.ResumeLayout(false);
            this.GrbxBatiment.ResumeLayout(false);
            this.GrbxProfil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbxPersonne;
        private System.Windows.Forms.ComboBox CbxPersonne;
        private System.Windows.Forms.GroupBox GrbxBatiment;
        private System.Windows.Forms.ComboBox CbxBatiment;
        private System.Windows.Forms.GroupBox GrbxProfil;
        private System.Windows.Forms.ComboBox CbxProfil;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbnPersonne;
        private System.Windows.Forms.RadioButton RbnBatiment;
        private System.Windows.Forms.RadioButton RbnProfil;
    }
}