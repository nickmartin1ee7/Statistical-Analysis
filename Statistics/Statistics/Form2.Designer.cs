namespace Statistics
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.tBox = new System.Windows.Forms.TextBox();
            this.loadLabel = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tBox
            // 
            this.tBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBox.Location = new System.Drawing.Point(0, 0);
            this.tBox.Multiline = true;
            this.tBox.Name = "tBox";
            this.tBox.ReadOnly = true;
            this.tBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox.Size = new System.Drawing.Size(234, 361);
            this.tBox.TabIndex = 0;
            this.tBox.Visible = false;
            this.tBox.WordWrap = false;
            // 
            // loadLabel
            // 
            this.loadLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.Location = new System.Drawing.Point(0, 0);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(234, 361);
            this.loadLabel.TabIndex = 1;
            this.loadLabel.Text = "Loading...";
            this.loadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Statistics.Form1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 361);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.tBox);
            this.Name = "Form2";
            this.Text = "Data Peek";
            this.Load += new System.EventHandler(this.Form2_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Label loadLabel;
    }
}