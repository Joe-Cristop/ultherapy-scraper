namespace UltherapyScraper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.leInputPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSelInputFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.leOutputPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSelOutputFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.leStatus = new MaterialSkin.Controls.MaterialLabel();
            this.btnStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Input File :";
            // 
            // leInputPath
            // 
            this.leInputPath.Depth = 0;
            this.leInputPath.Enabled = false;
            this.leInputPath.Hint = "";
            this.leInputPath.Location = new System.Drawing.Point(107, 79);
            this.leInputPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.leInputPath.Name = "leInputPath";
            this.leInputPath.PasswordChar = '\0';
            this.leInputPath.SelectedText = "";
            this.leInputPath.SelectionLength = 0;
            this.leInputPath.SelectionStart = 0;
            this.leInputPath.Size = new System.Drawing.Size(257, 23);
            this.leInputPath.TabIndex = 1;
            this.leInputPath.UseSystemPasswordChar = false;
            // 
            // btnSelInputFile
            // 
            this.btnSelInputFile.Depth = 0;
            this.btnSelInputFile.Location = new System.Drawing.Point(370, 79);
            this.btnSelInputFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelInputFile.Name = "btnSelInputFile";
            this.btnSelInputFile.Primary = true;
            this.btnSelInputFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelInputFile.TabIndex = 2;
            this.btnSelInputFile.Text = "Open";
            this.btnSelInputFile.UseVisualStyleBackColor = true;
            this.btnSelInputFile.Click += new System.EventHandler(this.btnSelInputFile_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 110);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Output File :";
            // 
            // leOutputPath
            // 
            this.leOutputPath.Depth = 0;
            this.leOutputPath.Enabled = false;
            this.leOutputPath.Hint = "";
            this.leOutputPath.Location = new System.Drawing.Point(107, 108);
            this.leOutputPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.leOutputPath.Name = "leOutputPath";
            this.leOutputPath.PasswordChar = '\0';
            this.leOutputPath.SelectedText = "";
            this.leOutputPath.SelectionLength = 0;
            this.leOutputPath.SelectionStart = 0;
            this.leOutputPath.Size = new System.Drawing.Size(257, 23);
            this.leOutputPath.TabIndex = 1;
            this.leOutputPath.UseSystemPasswordChar = false;
            // 
            // btnSelOutputFile
            // 
            this.btnSelOutputFile.Depth = 0;
            this.btnSelOutputFile.Location = new System.Drawing.Point(370, 108);
            this.btnSelOutputFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelOutputFile.Name = "btnSelOutputFile";
            this.btnSelOutputFile.Primary = true;
            this.btnSelOutputFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelOutputFile.TabIndex = 2;
            this.btnSelOutputFile.Text = "Save";
            this.btnSelOutputFile.UseVisualStyleBackColor = true;
            this.btnSelOutputFile.Click += new System.EventHandler(this.btnSelOutputFile_Click);
            // 
            // leStatus
            // 
            this.leStatus.AutoSize = true;
            this.leStatus.Depth = 0;
            this.leStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.leStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.leStatus.Location = new System.Drawing.Point(107, 138);
            this.leStatus.MinimumSize = new System.Drawing.Size(257, 0);
            this.leStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.leStatus.Name = "leStatus";
            this.leStatus.Size = new System.Drawing.Size(257, 19);
            this.leStatus.TabIndex = 3;
            this.leStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Depth = 0;
            this.btnStart.Location = new System.Drawing.Point(107, 165);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.Primary = true;
            this.btnStart.Size = new System.Drawing.Size(257, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 203);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.leStatus);
            this.Controls.Add(this.btnSelOutputFile);
            this.Controls.Add(this.btnSelInputFile);
            this.Controls.Add(this.leOutputPath);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.leInputPath);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ultherapy Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField leInputPath;
        private MaterialSkin.Controls.MaterialRaisedButton btnSelInputFile;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField leOutputPath;
        private MaterialSkin.Controls.MaterialRaisedButton btnSelOutputFile;
        private MaterialSkin.Controls.MaterialLabel leStatus;
        private MaterialSkin.Controls.MaterialRaisedButton btnStart;
    }
}

