namespace FindEvidenceMaterial
{
    partial class GameForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_SelectEvidence = new MaterialSkin.Controls.MaterialFlatButton();
            this.RB_Dna = new MaterialSkin.Controls.MaterialRadioButton();
            this.RB_Fingerprint = new MaterialSkin.Controls.MaterialRadioButton();
            this.RB_Weapon = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_Exit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_SelectEvidence);
            this.groupBox1.Controls.Add(this.RB_Dna);
            this.groupBox1.Controls.Add(this.RB_Fingerprint);
            this.groupBox1.Controls.Add(this.RB_Weapon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evidence";
            // 
            // BTN_SelectEvidence
            // 
            this.BTN_SelectEvidence.AutoSize = true;
            this.BTN_SelectEvidence.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_SelectEvidence.Depth = 0;
            this.BTN_SelectEvidence.Icon = null;
            this.BTN_SelectEvidence.Location = new System.Drawing.Point(90, 128);
            this.BTN_SelectEvidence.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_SelectEvidence.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_SelectEvidence.Name = "BTN_SelectEvidence";
            this.BTN_SelectEvidence.Primary = false;
            this.BTN_SelectEvidence.Size = new System.Drawing.Size(69, 36);
            this.BTN_SelectEvidence.TabIndex = 3;
            this.BTN_SelectEvidence.Text = "Select";
            this.BTN_SelectEvidence.UseVisualStyleBackColor = true;
            // 
            // RB_Dna
            // 
            this.RB_Dna.AutoSize = true;
            this.RB_Dna.Depth = 0;
            this.RB_Dna.Font = new System.Drawing.Font("Roboto", 10F);
            this.RB_Dna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RB_Dna.Location = new System.Drawing.Point(18, 91);
            this.RB_Dna.Margin = new System.Windows.Forms.Padding(0);
            this.RB_Dna.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RB_Dna.MouseState = MaterialSkin.MouseState.HOVER;
            this.RB_Dna.Name = "RB_Dna";
            this.RB_Dna.Ripple = true;
            this.RB_Dna.Size = new System.Drawing.Size(57, 30);
            this.RB_Dna.TabIndex = 2;
            this.RB_Dna.TabStop = true;
            this.RB_Dna.Text = "DNA";
            this.RB_Dna.UseVisualStyleBackColor = true;
            // 
            // RB_Fingerprint
            // 
            this.RB_Fingerprint.AutoSize = true;
            this.RB_Fingerprint.Depth = 0;
            this.RB_Fingerprint.Font = new System.Drawing.Font("Roboto", 10F);
            this.RB_Fingerprint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RB_Fingerprint.Location = new System.Drawing.Point(18, 61);
            this.RB_Fingerprint.Margin = new System.Windows.Forms.Padding(0);
            this.RB_Fingerprint.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RB_Fingerprint.MouseState = MaterialSkin.MouseState.HOVER;
            this.RB_Fingerprint.Name = "RB_Fingerprint";
            this.RB_Fingerprint.Ripple = true;
            this.RB_Fingerprint.Size = new System.Drawing.Size(96, 30);
            this.RB_Fingerprint.TabIndex = 1;
            this.RB_Fingerprint.TabStop = true;
            this.RB_Fingerprint.Text = "Fingerprint";
            this.RB_Fingerprint.UseVisualStyleBackColor = true;
            // 
            // RB_Weapon
            // 
            this.RB_Weapon.AutoSize = true;
            this.RB_Weapon.Depth = 0;
            this.RB_Weapon.Font = new System.Drawing.Font("Roboto", 10F);
            this.RB_Weapon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RB_Weapon.Location = new System.Drawing.Point(18, 31);
            this.RB_Weapon.Margin = new System.Windows.Forms.Padding(0);
            this.RB_Weapon.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RB_Weapon.MouseState = MaterialSkin.MouseState.HOVER;
            this.RB_Weapon.Name = "RB_Weapon";
            this.RB_Weapon.Ripple = true;
            this.RB_Weapon.Size = new System.Drawing.Size(127, 30);
            this.RB_Weapon.TabIndex = 0;
            this.RB_Weapon.TabStop = true;
            this.RB_Weapon.Text = "Murder Weapon";
            this.RB_Weapon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 174);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 137);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(154, 23);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "0 / 3";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 114);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(154, 23);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Clues Found:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 91);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(154, 23);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "0";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 68);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(154, 23);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Current Score:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 45);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(154, 23);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "0";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(154, 23);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "High Score:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_Exit);
            this.groupBox3.Controls.Add(this.materialFlatButton1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 128);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu";
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.AutoSize = true;
            this.BTN_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Exit.Depth = 0;
            this.BTN_Exit.Icon = null;
            this.BTN_Exit.Location = new System.Drawing.Point(38, 69);
            this.BTN_Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Primary = true;
            this.BTN_Exit.Size = new System.Drawing.Size(91, 36);
            this.BTN_Exit.TabIndex = 1;
            this.BTN_Exit.Text = "Exit Game";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(14, 24);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(138, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Start New Game";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(193, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(716, 580);
            this.MinimumSize = new System.Drawing.Size(193, 580);
            this.Name = "GameForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.Text = "GameForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton RB_Weapon;
        private MaterialSkin.Controls.MaterialRadioButton RB_Fingerprint;
        private MaterialSkin.Controls.MaterialRadioButton RB_Dna;
        private MaterialSkin.Controls.MaterialFlatButton BTN_SelectEvidence;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRaisedButton BTN_Exit;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}