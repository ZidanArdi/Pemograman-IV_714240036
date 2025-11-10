namespace P5_2_714240036
{
    partial class ChildForm
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.DateOption = new System.Windows.Forms.RadioButton();
            this.TimeOption = new System.Windows.Forms.RadioButton();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(0, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(291, 32);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(180, 88);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.TimeOption);
            this.OutputGroupBox.Controls.Add(this.DateOption);
            this.OutputGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutputGroupBox.Location = new System.Drawing.Point(0, 168);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(291, 104);
            this.OutputGroupBox.TabIndex = 2;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "ChooseOutput";
            // 
            // DateOption
            // 
            this.DateOption.Location = new System.Drawing.Point(16, 21);
            this.DateOption.Name = "DateOption";
            this.DateOption.Size = new System.Drawing.Size(168, 24);
            this.DateOption.TabIndex = 1;
            this.DateOption.TabStop = true;
            this.DateOption.Text = "Display Current D&ate\r\n";
            this.DateOption.UseVisualStyleBackColor = true;
            this.DateOption.CheckedChanged += new System.EventHandler(this.DateOption_CheckedChanged);
            // 
            // TimeOption
            // 
            this.TimeOption.Location = new System.Drawing.Point(16, 53);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(168, 24);
            this.TimeOption.TabIndex = 0;
            this.TimeOption.TabStop = true;
            this.TimeOption.Text = "Display Current T&ime";
            this.TimeOption.UseVisualStyleBackColor = true;
            this.TimeOption.CheckedChanged += new System.EventHandler(this.TimeOption_CheckedChanged);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(36, 88);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 25);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 272);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.OutputLabel);
            this.Name = "ChildForm";
            this.Text = "Child Form";
            this.OutputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.RadioButton DateOption;
        private System.Windows.Forms.RadioButton TimeOption;
        private System.Windows.Forms.Button DisplayButton;
    }
}