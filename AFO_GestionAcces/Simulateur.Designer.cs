
namespace AFO_GestionAcces
{
    partial class Simulateur
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxPersonne = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbxBatiment = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CbxProfile = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.CbxPersonne);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personne";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Green;
            this.groupBox2.Controls.Add(this.CbxBatiment);
            this.groupBox2.Location = new System.Drawing.Point(466, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Batiment";
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Blue;
            this.groupBox3.Controls.Add(this.CbxProfile);
            this.groupBox3.Location = new System.Drawing.Point(12, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 177);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profil";
            // 
            // CbxProfile
            // 
            this.CbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxProfile.FormattingEnabled = true;
            this.CbxProfile.Location = new System.Drawing.Point(7, 27);
            this.CbxProfile.Name = "CbxProfile";
            this.CbxProfile.Size = new System.Drawing.Size(151, 28);
            this.CbxProfile.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(466, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 177);
            this.button1.TabIndex = 3;
            this.button1.Text = "Simuler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(222, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // Simulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Simulateur";
            this.Text = "GestionAccès";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxBatiment;
        private System.Windows.Forms.ComboBox CbxProfile;
        private System.Windows.Forms.ComboBox CbxPersonne;
    }
}

