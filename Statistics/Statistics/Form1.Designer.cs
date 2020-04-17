namespace Statistics
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
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.linesLabel = new System.Windows.Forms.Label();
            this.linesTextBox = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.stdDeviationLabel = new System.Windows.Forms.Label();
            this.stdDeviationTextBox = new System.Windows.Forms.TextBox();
            this.stdErrorLabel = new System.Windows.Forms.Label();
            this.stdErrorTextBox = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.roundChkBox = new System.Windows.Forms.CheckBox();
            this.randGenBtn = new System.Windows.Forms.Button();
            this.randMaxTextBox = new System.Windows.Forms.TextBox();
            this.randMinTextbox = new System.Windows.Forms.TextBox();
            this.randMinLabel = new System.Windows.Forms.Label();
            this.randMaxLabel = new System.Windows.Forms.Label();
            this.randNTextBox = new System.Windows.Forms.TextBox();
            this.randNLabel = new System.Windows.Forms.Label();
            this.zTestLabel = new System.Windows.Forms.Label();
            this.zTestTextBox = new System.Windows.Forms.TextBox();
            this.nullHypTextBox = new System.Windows.Forms.TextBox();
            this.nullHypLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.watchTimeLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chooseFileBtn.Location = new System.Drawing.Point(0, 204);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(415, 23);
            this.chooseFileBtn.TabIndex = 0;
            this.chooseFileBtn.Text = "Choose file...";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearBtn.Location = new System.Drawing.Point(197, 114);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(68, 23);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // linesLabel
            // 
            this.linesLabel.AutoSize = true;
            this.linesLabel.Location = new System.Drawing.Point(50, 16);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(35, 13);
            this.linesLabel.TabIndex = 90;
            this.linesLabel.Text = "Lines:";
            // 
            // linesTextBox
            // 
            this.linesTextBox.Location = new System.Drawing.Point(91, 12);
            this.linesTextBox.MaxLength = 10;
            this.linesTextBox.Name = "linesTextBox";
            this.linesTextBox.ReadOnly = true;
            this.linesTextBox.Size = new System.Drawing.Size(100, 20);
            this.linesTextBox.TabIndex = 91;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileLabel.Location = new System.Drawing.Point(0, 191);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(26, 13);
            this.fileLabel.TabIndex = 103;
            this.fileLabel.Text = "File:";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(54, 41);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(31, 13);
            this.sumLabel.TabIndex = 93;
            this.sumLabel.Text = "Sum:";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(91, 37);
            this.sumTextBox.MaxLength = 10;
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.ReadOnly = true;
            this.sumTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumTextBox.TabIndex = 94;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(35, 67);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(50, 13);
            this.averageLabel.TabIndex = 95;
            this.averageLabel.Text = "Average:";
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(91, 63);
            this.averageTextBox.MaxLength = 10;
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.ReadOnly = true;
            this.averageTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageTextBox.TabIndex = 96;
            // 
            // stdDeviationLabel
            // 
            this.stdDeviationLabel.AutoSize = true;
            this.stdDeviationLabel.Location = new System.Drawing.Point(8, 93);
            this.stdDeviationLabel.Name = "stdDeviationLabel";
            this.stdDeviationLabel.Size = new System.Drawing.Size(77, 13);
            this.stdDeviationLabel.TabIndex = 97;
            this.stdDeviationLabel.Text = "Std. Deviation:";
            // 
            // stdDeviationTextBox
            // 
            this.stdDeviationTextBox.Location = new System.Drawing.Point(91, 89);
            this.stdDeviationTextBox.MaxLength = 10;
            this.stdDeviationTextBox.Name = "stdDeviationTextBox";
            this.stdDeviationTextBox.ReadOnly = true;
            this.stdDeviationTextBox.Size = new System.Drawing.Size(100, 20);
            this.stdDeviationTextBox.TabIndex = 98;
            // 
            // stdErrorLabel
            // 
            this.stdErrorLabel.AutoSize = true;
            this.stdErrorLabel.Location = new System.Drawing.Point(34, 119);
            this.stdErrorLabel.Name = "stdErrorLabel";
            this.stdErrorLabel.Size = new System.Drawing.Size(51, 13);
            this.stdErrorLabel.TabIndex = 99;
            this.stdErrorLabel.Text = "Std. Error";
            // 
            // stdErrorTextBox
            // 
            this.stdErrorTextBox.Location = new System.Drawing.Point(91, 115);
            this.stdErrorTextBox.MaxLength = 10;
            this.stdErrorTextBox.Name = "stdErrorTextBox";
            this.stdErrorTextBox.ReadOnly = true;
            this.stdErrorTextBox.Size = new System.Drawing.Size(100, 20);
            this.stdErrorTextBox.TabIndex = 100;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLabel.AutoEllipsis = true;
            this.fileNameLabel.Location = new System.Drawing.Point(32, 191);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(371, 13);
            this.fileNameLabel.TabIndex = 102;
            // 
            // calcBtn
            // 
            this.calcBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calcBtn.Location = new System.Drawing.Point(197, 85);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(68, 23);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // roundChkBox
            // 
            this.roundChkBox.AutoSize = true;
            this.roundChkBox.Checked = true;
            this.roundChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.roundChkBox.Location = new System.Drawing.Point(224, 52);
            this.roundChkBox.Name = "roundChkBox";
            this.roundChkBox.Size = new System.Drawing.Size(15, 14);
            this.roundChkBox.TabIndex = 4;
            this.roundChkBox.UseVisualStyleBackColor = true;
            this.roundChkBox.CheckedChanged += new System.EventHandler(this.roundChkBox_CheckedChanged);
            // 
            // randGenBtn
            // 
            this.randGenBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.randGenBtn.Location = new System.Drawing.Point(286, 112);
            this.randGenBtn.Name = "randGenBtn";
            this.randGenBtn.Size = new System.Drawing.Size(113, 24);
            this.randGenBtn.TabIndex = 8;
            this.randGenBtn.Text = "Random numbers";
            this.randGenBtn.UseVisualStyleBackColor = true;
            this.randGenBtn.Click += new System.EventHandler(this.randGenBtn_Click);
            // 
            // randMaxTextBox
            // 
            this.randMaxTextBox.Location = new System.Drawing.Point(312, 83);
            this.randMaxTextBox.MaxLength = 10;
            this.randMaxTextBox.Name = "randMaxTextBox";
            this.randMaxTextBox.Size = new System.Drawing.Size(87, 20);
            this.randMaxTextBox.TabIndex = 7;
            // 
            // randMinTextbox
            // 
            this.randMinTextbox.Location = new System.Drawing.Point(312, 56);
            this.randMinTextbox.MaxLength = 10;
            this.randMinTextbox.Name = "randMinTextbox";
            this.randMinTextbox.Size = new System.Drawing.Size(87, 20);
            this.randMinTextbox.TabIndex = 6;
            // 
            // randMinLabel
            // 
            this.randMinLabel.AutoSize = true;
            this.randMinLabel.Location = new System.Drawing.Point(279, 59);
            this.randMinLabel.Name = "randMinLabel";
            this.randMinLabel.Size = new System.Drawing.Size(27, 13);
            this.randMinLabel.TabIndex = 22;
            this.randMinLabel.Text = "Min:";
            // 
            // randMaxLabel
            // 
            this.randMaxLabel.AutoSize = true;
            this.randMaxLabel.Location = new System.Drawing.Point(276, 83);
            this.randMaxLabel.Name = "randMaxLabel";
            this.randMaxLabel.Size = new System.Drawing.Size(30, 13);
            this.randMaxLabel.TabIndex = 23;
            this.randMaxLabel.Text = "Max:";
            // 
            // randNTextBox
            // 
            this.randNTextBox.Location = new System.Drawing.Point(312, 30);
            this.randNTextBox.MaxLength = 10;
            this.randNTextBox.Name = "randNTextBox";
            this.randNTextBox.Size = new System.Drawing.Size(87, 20);
            this.randNTextBox.TabIndex = 5;
            // 
            // randNLabel
            // 
            this.randNLabel.AutoSize = true;
            this.randNLabel.Location = new System.Drawing.Point(276, 33);
            this.randNLabel.Name = "randNLabel";
            this.randNLabel.Size = new System.Drawing.Size(30, 13);
            this.randNLabel.TabIndex = 25;
            this.randNLabel.Text = "Size:";
            // 
            // zTestLabel
            // 
            this.zTestLabel.AutoSize = true;
            this.zTestLabel.Location = new System.Drawing.Point(44, 145);
            this.zTestLabel.Name = "zTestLabel";
            this.zTestLabel.Size = new System.Drawing.Size(41, 13);
            this.zTestLabel.TabIndex = 104;
            this.zTestLabel.Text = "Z-Test:";
            // 
            // zTestTextBox
            // 
            this.zTestTextBox.Location = new System.Drawing.Point(91, 141);
            this.zTestTextBox.MaxLength = 10;
            this.zTestTextBox.Name = "zTestTextBox";
            this.zTestTextBox.ReadOnly = true;
            this.zTestTextBox.Size = new System.Drawing.Size(100, 20);
            this.zTestTextBox.TabIndex = 105;
            // 
            // nullHypTextBox
            // 
            this.nullHypTextBox.Location = new System.Drawing.Point(286, 142);
            this.nullHypTextBox.MaxLength = 10;
            this.nullHypTextBox.Name = "nullHypTextBox";
            this.nullHypTextBox.Size = new System.Drawing.Size(113, 20);
            this.nullHypTextBox.TabIndex = 9;
            this.nullHypTextBox.TextChanged += new System.EventHandler(this.nullHypTextBox_TextChanged);
            // 
            // nullHypLabel
            // 
            this.nullHypLabel.AutoSize = true;
            this.nullHypLabel.Location = new System.Drawing.Point(197, 145);
            this.nullHypLabel.Name = "nullHypLabel";
            this.nullHypLabel.Size = new System.Drawing.Size(83, 13);
            this.nullHypLabel.TabIndex = 106;
            this.nullHypLabel.Text = "Null Hypothesis:";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(206, 33);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(51, 13);
            this.roundLabel.TabIndex = 101;
            this.roundLabel.Text = "Round?";
            // 
            // watchTimeLabel
            // 
            this.watchTimeLabel.Location = new System.Drawing.Point(197, 169);
            this.watchTimeLabel.Name = "watchTimeLabel";
            this.watchTimeLabel.Size = new System.Drawing.Size(197, 21);
            this.watchTimeLabel.TabIndex = 107;
            this.watchTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.saveBtn.Location = new System.Drawing.Point(91, 167);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 23);
            this.saveBtn.TabIndex = 108;
            this.saveBtn.Text = "Save everything";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearBtn;
            this.ClientSize = new System.Drawing.Size(415, 227);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.watchTimeLabel);
            this.Controls.Add(this.nullHypLabel);
            this.Controls.Add(this.nullHypTextBox);
            this.Controls.Add(this.zTestLabel);
            this.Controls.Add(this.zTestTextBox);
            this.Controls.Add(this.randNLabel);
            this.Controls.Add(this.randNTextBox);
            this.Controls.Add(this.randMaxLabel);
            this.Controls.Add(this.randMinLabel);
            this.Controls.Add(this.randMinTextbox);
            this.Controls.Add(this.randMaxTextBox);
            this.Controls.Add(this.randGenBtn);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.roundChkBox);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.stdErrorLabel);
            this.Controls.Add(this.stdErrorTextBox);
            this.Controls.Add(this.stdDeviationLabel);
            this.Controls.Add(this.stdDeviationTextBox);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.linesLabel);
            this.Controls.Add(this.linesTextBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.chooseFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistical Analysis";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label linesLabel;
        private System.Windows.Forms.TextBox linesTextBox;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Label stdDeviationLabel;
        private System.Windows.Forms.TextBox stdDeviationTextBox;
        private System.Windows.Forms.Label stdErrorLabel;
        private System.Windows.Forms.TextBox stdErrorTextBox;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.CheckBox roundChkBox;
        private System.Windows.Forms.Button randGenBtn;
        private System.Windows.Forms.TextBox randMaxTextBox;
        private System.Windows.Forms.TextBox randMinTextbox;
        private System.Windows.Forms.Label randMinLabel;
        private System.Windows.Forms.Label randMaxLabel;
        private System.Windows.Forms.TextBox randNTextBox;
        private System.Windows.Forms.Label randNLabel;
        private System.Windows.Forms.Label zTestLabel;
        private System.Windows.Forms.TextBox zTestTextBox;
        private System.Windows.Forms.TextBox nullHypTextBox;
        private System.Windows.Forms.Label nullHypLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label watchTimeLabel;
        private System.Windows.Forms.Button saveBtn;
    }
}

