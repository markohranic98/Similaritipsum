namespace Similaritipsum
{
    partial class MainForm
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
            this.streamNumberCbox = new System.Windows.Forms.ComboBox();
            this.streamNumberLabel = new System.Windows.Forms.Label();
            this.showPirateReferencesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // streamNumberCbox
            // 
            this.streamNumberCbox.FormattingEnabled = true;
            this.streamNumberCbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.streamNumberCbox.Location = new System.Drawing.Point(26, 39);
            this.streamNumberCbox.Name = "streamNumberCbox";
            this.streamNumberCbox.Size = new System.Drawing.Size(121, 21);
            this.streamNumberCbox.TabIndex = 1;
            this.streamNumberCbox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // streamNumberLabel
            // 
            this.streamNumberLabel.AutoSize = true;
            this.streamNumberLabel.Location = new System.Drawing.Point(12, 23);
            this.streamNumberLabel.Name = "streamNumberLabel";
            this.streamNumberLabel.Size = new System.Drawing.Size(135, 13);
            this.streamNumberLabel.TabIndex = 2;
            this.streamNumberLabel.Text = "Choose number of streams:";
            // 
            // showPirateReferencesBtn
            // 
            this.showPirateReferencesBtn.Location = new System.Drawing.Point(189, 37);
            this.showPirateReferencesBtn.Name = "showPirateReferencesBtn";
            this.showPirateReferencesBtn.Size = new System.Drawing.Size(103, 23);
            this.showPirateReferencesBtn.TabIndex = 3;
            this.showPirateReferencesBtn.Text = "Pirate references";
            this.showPirateReferencesBtn.UseVisualStyleBackColor = true;
            this.showPirateReferencesBtn.Click += new System.EventHandler(this.showPirateReferencesBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 94);
            this.Controls.Add(this.showPirateReferencesBtn);
            this.Controls.Add(this.streamNumberLabel);
            this.Controls.Add(this.streamNumberCbox);
            this.Name = "MainForm";
            this.Text = "Similaritipsum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox streamNumberCbox;
        private System.Windows.Forms.Label streamNumberLabel;
        private System.Windows.Forms.Button showPirateReferencesBtn;
    }
}

