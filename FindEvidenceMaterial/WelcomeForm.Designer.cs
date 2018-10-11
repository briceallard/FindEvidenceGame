namespace FindEvidenceMaterial
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.GB_Instructions = new System.Windows.Forms.GroupBox();
            this.PB_Fingerprint = new System.Windows.Forms.PictureBox();
            this.PB_MagGlass = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GB_Upload = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Upload = new MaterialSkin.Controls.MaterialFlatButton();
            this.LBL_Path = new MaterialSkin.Controls.MaterialLabel();
            this.TB_Path = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BTN_ChooseFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.GB_Start = new System.Windows.Forms.GroupBox();
            this.BTN_Close = new MaterialSkin.Controls.MaterialFlatButton();
            this.BTN_Start = new MaterialSkin.Controls.MaterialFlatButton();
            this.LBL_MaxSize = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TB_GRIDY = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TB_GRIDX = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LBL_GridSize = new MaterialSkin.Controls.MaterialLabel();
            this.GB_Instructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fingerprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MagGlass)).BeginInit();
            this.GB_Upload.SuspendLayout();
            this.GB_Start.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Instructions
            // 
            this.GB_Instructions.Controls.Add(this.PB_Fingerprint);
            this.GB_Instructions.Controls.Add(this.PB_MagGlass);
            this.GB_Instructions.Controls.Add(this.richTextBox1);
            this.GB_Instructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_Instructions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Instructions.ForeColor = System.Drawing.Color.Black;
            this.GB_Instructions.Location = new System.Drawing.Point(12, 73);
            this.GB_Instructions.Name = "GB_Instructions";
            this.GB_Instructions.Size = new System.Drawing.Size(491, 219);
            this.GB_Instructions.TabIndex = 0;
            this.GB_Instructions.TabStop = false;
            this.GB_Instructions.Text = "Instructions";
            // 
            // PB_Fingerprint
            // 
            this.PB_Fingerprint.BackColor = System.Drawing.Color.Transparent;
            this.PB_Fingerprint.Image = ((System.Drawing.Image)(resources.GetObject("PB_Fingerprint.Image")));
            this.PB_Fingerprint.Location = new System.Drawing.Point(423, 39);
            this.PB_Fingerprint.Name = "PB_Fingerprint";
            this.PB_Fingerprint.Size = new System.Drawing.Size(24, 24);
            this.PB_Fingerprint.TabIndex = 2;
            this.PB_Fingerprint.TabStop = false;
            this.PB_Fingerprint.Visible = false;
            // 
            // PB_MagGlass
            // 
            this.PB_MagGlass.BackColor = System.Drawing.Color.Transparent;
            this.PB_MagGlass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_MagGlass.BackgroundImage")));
            this.PB_MagGlass.Location = new System.Drawing.Point(410, 26);
            this.PB_MagGlass.Name = "PB_MagGlass";
            this.PB_MagGlass.Size = new System.Drawing.Size(64, 64);
            this.PB_MagGlass.TabIndex = 1;
            this.PB_MagGlass.TabStop = false;
            this.PB_MagGlass.MouseEnter += new System.EventHandler(this.PB_Fingerprint_MouseEnter);
            this.PB_MagGlass.MouseLeave += new System.EventHandler(this.PB_Fingerprint_MouseExit);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(485, 193);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // GB_Upload
            // 
            this.GB_Upload.Controls.Add(this.label1);
            this.GB_Upload.Controls.Add(this.BTN_Upload);
            this.GB_Upload.Controls.Add(this.LBL_Path);
            this.GB_Upload.Controls.Add(this.TB_Path);
            this.GB_Upload.Controls.Add(this.BTN_ChooseFile);
            this.GB_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_Upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Upload.ForeColor = System.Drawing.Color.Black;
            this.GB_Upload.Location = new System.Drawing.Point(12, 298);
            this.GB_Upload.Name = "GB_Upload";
            this.GB_Upload.Size = new System.Drawing.Size(491, 112);
            this.GB_Upload.TabIndex = 1;
            this.GB_Upload.TabStop = false;
            this.GB_Upload.Text = "Upload Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "* Settings.txt";
            // 
            // BTN_Upload
            // 
            this.BTN_Upload.AutoSize = true;
            this.BTN_Upload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Upload.Depth = 0;
            this.BTN_Upload.Icon = null;
            this.BTN_Upload.Location = new System.Drawing.Point(410, 67);
            this.BTN_Upload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_Upload.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Upload.Name = "BTN_Upload";
            this.BTN_Upload.Primary = false;
            this.BTN_Upload.Size = new System.Drawing.Size(74, 36);
            this.BTN_Upload.TabIndex = 4;
            this.BTN_Upload.Text = "Upload";
            this.BTN_Upload.UseVisualStyleBackColor = true;
            this.BTN_Upload.Click += new System.EventHandler(this.BTN_Upload_Click);
            // 
            // LBL_Path
            // 
            this.LBL_Path.AutoSize = true;
            this.LBL_Path.Depth = 0;
            this.LBL_Path.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBL_Path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBL_Path.Location = new System.Drawing.Point(118, 33);
            this.LBL_Path.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL_Path.Name = "LBL_Path";
            this.LBL_Path.Size = new System.Drawing.Size(52, 19);
            this.LBL_Path.TabIndex = 3;
            this.LBL_Path.Text = "PATH:";
            // 
            // TB_Path
            // 
            this.TB_Path.Depth = 0;
            this.TB_Path.Hint = "";
            this.TB_Path.Location = new System.Drawing.Point(176, 33);
            this.TB_Path.MaxLength = 32767;
            this.TB_Path.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.PasswordChar = '\0';
            this.TB_Path.SelectedText = "";
            this.TB_Path.SelectionLength = 0;
            this.TB_Path.SelectionStart = 0;
            this.TB_Path.Size = new System.Drawing.Size(309, 23);
            this.TB_Path.TabIndex = 2;
            this.TB_Path.TabStop = false;
            this.TB_Path.UseSystemPasswordChar = false;
            // 
            // BTN_ChooseFile
            // 
            this.BTN_ChooseFile.AutoSize = true;
            this.BTN_ChooseFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_ChooseFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_ChooseFile.Depth = 0;
            this.BTN_ChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ChooseFile.Icon = null;
            this.BTN_ChooseFile.Location = new System.Drawing.Point(7, 23);
            this.BTN_ChooseFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_ChooseFile.Name = "BTN_ChooseFile";
            this.BTN_ChooseFile.Primary = true;
            this.BTN_ChooseFile.Size = new System.Drawing.Size(105, 36);
            this.BTN_ChooseFile.TabIndex = 1;
            this.BTN_ChooseFile.Text = "Choose File";
            this.BTN_ChooseFile.UseVisualStyleBackColor = false;
            this.BTN_ChooseFile.Click += new System.EventHandler(this.BTN_ChooseFile_Click);
            // 
            // GB_Start
            // 
            this.GB_Start.Controls.Add(this.BTN_Close);
            this.GB_Start.Controls.Add(this.BTN_Start);
            this.GB_Start.Controls.Add(this.LBL_MaxSize);
            this.GB_Start.Controls.Add(this.materialLabel2);
            this.GB_Start.Controls.Add(this.TB_GRIDY);
            this.GB_Start.Controls.Add(this.TB_GRIDX);
            this.GB_Start.Controls.Add(this.LBL_GridSize);
            this.GB_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_Start.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Start.ForeColor = System.Drawing.Color.Black;
            this.GB_Start.Location = new System.Drawing.Point(12, 416);
            this.GB_Start.Name = "GB_Start";
            this.GB_Start.Size = new System.Drawing.Size(491, 112);
            this.GB_Start.TabIndex = 7;
            this.GB_Start.TabStop = false;
            this.GB_Start.Text = "Start Game";
            // 
            // BTN_Close
            // 
            this.BTN_Close.AutoSize = true;
            this.BTN_Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Close.Depth = 0;
            this.BTN_Close.Icon = null;
            this.BTN_Close.Location = new System.Drawing.Point(420, 67);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_Close.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Primary = false;
            this.BTN_Close.Size = new System.Drawing.Size(63, 36);
            this.BTN_Close.TabIndex = 6;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.AutoSize = true;
            this.BTN_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Start.Depth = 0;
            this.BTN_Start.Icon = null;
            this.BTN_Start.Location = new System.Drawing.Point(348, 67);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_Start.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Primary = false;
            this.BTN_Start.Size = new System.Drawing.Size(64, 36);
            this.BTN_Start.TabIndex = 5;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            // 
            // LBL_MaxSize
            // 
            this.LBL_MaxSize.AutoSize = true;
            this.LBL_MaxSize.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MaxSize.Location = new System.Drawing.Point(64, 67);
            this.LBL_MaxSize.Name = "LBL_MaxSize";
            this.LBL_MaxSize.Size = new System.Drawing.Size(138, 15);
            this.LBL_MaxSize.TabIndex = 4;
            this.LBL_MaxSize.Text = "* No Maximum Grid Size";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(211, 34);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(16, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "x";
            // 
            // TB_GRIDY
            // 
            this.TB_GRIDY.Depth = 0;
            this.TB_GRIDY.Hint = "";
            this.TB_GRIDY.Location = new System.Drawing.Point(233, 34);
            this.TB_GRIDY.MaxLength = 32767;
            this.TB_GRIDY.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_GRIDY.Name = "TB_GRIDY";
            this.TB_GRIDY.PasswordChar = '\0';
            this.TB_GRIDY.SelectedText = "";
            this.TB_GRIDY.SelectionLength = 0;
            this.TB_GRIDY.SelectionStart = 0;
            this.TB_GRIDY.Size = new System.Drawing.Size(32, 23);
            this.TB_GRIDY.TabIndex = 2;
            this.TB_GRIDY.TabStop = false;
            this.TB_GRIDY.Text = "0";
            this.TB_GRIDY.UseSystemPasswordChar = false;
            // 
            // TB_GRIDX
            // 
            this.TB_GRIDX.Depth = 0;
            this.TB_GRIDX.Hint = "";
            this.TB_GRIDX.Location = new System.Drawing.Point(173, 34);
            this.TB_GRIDX.MaxLength = 32767;
            this.TB_GRIDX.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_GRIDX.Name = "TB_GRIDX";
            this.TB_GRIDX.PasswordChar = '\0';
            this.TB_GRIDX.SelectedText = "";
            this.TB_GRIDX.SelectionLength = 0;
            this.TB_GRIDX.SelectionStart = 0;
            this.TB_GRIDX.Size = new System.Drawing.Size(32, 23);
            this.TB_GRIDX.TabIndex = 1;
            this.TB_GRIDX.TabStop = false;
            this.TB_GRIDX.Text = "0";
            this.TB_GRIDX.UseSystemPasswordChar = false;
            // 
            // LBL_GridSize
            // 
            this.LBL_GridSize.AutoSize = true;
            this.LBL_GridSize.Depth = 0;
            this.LBL_GridSize.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBL_GridSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBL_GridSize.Location = new System.Drawing.Point(6, 34);
            this.LBL_GridSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL_GridSize.Name = "LBL_GridSize";
            this.LBL_GridSize.Size = new System.Drawing.Size(161, 19);
            this.LBL_GridSize.TabIndex = 0;
            this.LBL_GridSize.Text = "Enter Search Grid Size:";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(516, 540);
            this.Controls.Add(this.GB_Start);
            this.Controls.Add(this.GB_Upload);
            this.Controls.Add(this.GB_Instructions);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(516, 540);
            this.MinimumSize = new System.Drawing.Size(516, 540);
            this.Name = "WelcomeForm";
            this.Text = "Find Evidence";
            this.GB_Instructions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fingerprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MagGlass)).EndInit();
            this.GB_Upload.ResumeLayout(false);
            this.GB_Upload.PerformLayout();
            this.GB_Start.ResumeLayout(false);
            this.GB_Start.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Instructions;
        private System.Windows.Forms.GroupBox GB_Upload;
        private MaterialSkin.Controls.MaterialSingleLineTextField TB_Path;
        private MaterialSkin.Controls.MaterialRaisedButton BTN_ChooseFile;
        private MaterialSkin.Controls.MaterialLabel LBL_Path;
        private MaterialSkin.Controls.MaterialFlatButton BTN_Upload;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox PB_MagGlass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_Start;
        private MaterialSkin.Controls.MaterialSingleLineTextField TB_GRIDY;
        private MaterialSkin.Controls.MaterialSingleLineTextField TB_GRIDX;
        private MaterialSkin.Controls.MaterialLabel LBL_GridSize;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label LBL_MaxSize;
        private MaterialSkin.Controls.MaterialFlatButton BTN_Start;
        private MaterialSkin.Controls.MaterialFlatButton BTN_Close;
        private System.Windows.Forms.PictureBox PB_Fingerprint;
    }
}

