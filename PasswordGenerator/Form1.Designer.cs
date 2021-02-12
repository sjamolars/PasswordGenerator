
namespace PasswordGenerator
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
            this.title = new System.Windows.Forms.Label();
            this.IncludeSymLabel = new System.Windows.Forms.Label();
            this.IncludeSymCBox = new System.Windows.Forms.CheckBox();
            this.IncludeNumsLabel = new System.Windows.Forms.Label();
            this.IncludeNumsCBox = new System.Windows.Forms.CheckBox();
            this.PassLengthBox = new System.Windows.Forms.NumericUpDown();
            this.PassLengthLabel = new System.Windows.Forms.Label();
            this.GenPassButton = new System.Windows.Forms.Button();
            this.PassOutputTBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PassLengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(59, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(457, 54);
            this.title.TabIndex = 0;
            this.title.Text = "PASSWORD GENERATOR";
            // 
            // IncludeSymLabel
            // 
            this.IncludeSymLabel.AutoSize = true;
            this.IncludeSymLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeSymLabel.Location = new System.Drawing.Point(63, 144);
            this.IncludeSymLabel.Name = "IncludeSymLabel";
            this.IncludeSymLabel.Size = new System.Drawing.Size(232, 28);
            this.IncludeSymLabel.TabIndex = 1;
            this.IncludeSymLabel.Text = "Include Symbols (#%^*$)";
            // 
            // IncludeSymCBox
            // 
            this.IncludeSymCBox.AutoSize = true;
            this.IncludeSymCBox.Checked = true;
            this.IncludeSymCBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeSymCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeSymCBox.Location = new System.Drawing.Point(311, 153);
            this.IncludeSymCBox.Name = "IncludeSymCBox";
            this.IncludeSymCBox.Size = new System.Drawing.Size(18, 17);
            this.IncludeSymCBox.TabIndex = 2;
            this.IncludeSymCBox.UseVisualStyleBackColor = true;
            // 
            // IncludeNumsLabel
            // 
            this.IncludeNumsLabel.AutoSize = true;
            this.IncludeNumsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeNumsLabel.Location = new System.Drawing.Point(63, 188);
            this.IncludeNumsLabel.Name = "IncludeNumsLabel";
            this.IncludeNumsLabel.Size = new System.Drawing.Size(232, 28);
            this.IncludeNumsLabel.TabIndex = 3;
            this.IncludeNumsLabel.Text = "Include Numbers (12345)";
            // 
            // IncludeNumsCBox
            // 
            this.IncludeNumsCBox.AutoSize = true;
            this.IncludeNumsCBox.Checked = true;
            this.IncludeNumsCBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeNumsCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeNumsCBox.Location = new System.Drawing.Point(311, 197);
            this.IncludeNumsCBox.Name = "IncludeNumsCBox";
            this.IncludeNumsCBox.Size = new System.Drawing.Size(18, 17);
            this.IncludeNumsCBox.TabIndex = 4;
            this.IncludeNumsCBox.UseVisualStyleBackColor = true;
            // 
            // PassLengthBox
            // 
            this.PassLengthBox.Location = new System.Drawing.Point(311, 236);
            this.PassLengthBox.Name = "PassLengthBox";
            this.PassLengthBox.Size = new System.Drawing.Size(52, 22);
            this.PassLengthBox.TabIndex = 5;
            this.PassLengthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.PassLengthBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // PassLengthLabel
            // 
            this.PassLengthLabel.AutoSize = true;
            this.PassLengthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLengthLabel.Location = new System.Drawing.Point(63, 232);
            this.PassLengthLabel.Name = "PassLengthLabel";
            this.PassLengthLabel.Size = new System.Drawing.Size(158, 28);
            this.PassLengthLabel.TabIndex = 6;
            this.PassLengthLabel.Text = "Password Length";
            // 
            // GenPassButton
            // 
            this.GenPassButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GenPassButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GenPassButton.FlatAppearance.BorderSize = 0;
            this.GenPassButton.Location = new System.Drawing.Point(68, 295);
            this.GenPassButton.Name = "GenPassButton";
            this.GenPassButton.Size = new System.Drawing.Size(448, 98);
            this.GenPassButton.TabIndex = 7;
            this.GenPassButton.Text = "GENERATE PASSWORD";
            this.GenPassButton.UseVisualStyleBackColor = false;
            this.GenPassButton.Click += new System.EventHandler(this.GenPassButton_Click);
            // 
            // PassOutputTBox
            // 
            this.PassOutputTBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassOutputTBox.Location = new System.Drawing.Point(68, 419);
            this.PassOutputTBox.Multiline = true;
            this.PassOutputTBox.Name = "PassOutputTBox";
            this.PassOutputTBox.Size = new System.Drawing.Size(448, 98);
            this.PassOutputTBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(577, 529);
            this.Controls.Add(this.PassOutputTBox);
            this.Controls.Add(this.GenPassButton);
            this.Controls.Add(this.PassLengthLabel);
            this.Controls.Add(this.PassLengthBox);
            this.Controls.Add(this.IncludeNumsCBox);
            this.Controls.Add(this.IncludeNumsLabel);
            this.Controls.Add(this.IncludeSymCBox);
            this.Controls.Add(this.IncludeSymLabel);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(595, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(595, 576);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasword Generator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PassLengthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label IncludeSymLabel;
        private System.Windows.Forms.CheckBox IncludeSymCBox;
        private System.Windows.Forms.Label IncludeNumsLabel;
        private System.Windows.Forms.CheckBox IncludeNumsCBox;
        private System.Windows.Forms.NumericUpDown PassLengthBox;
        private System.Windows.Forms.Label PassLengthLabel;
        private System.Windows.Forms.Button GenPassButton;
        private System.Windows.Forms.TextBox PassOutputTBox;
    }
}

